$Language = "dotnet"
$LanguageShort = "net"
$LanguageDisplayName = ".NET"
$PackageRepository = "Nuget"
$packagePattern = "*.nupkg"
$MetadataUri = "https://raw.githubusercontent.com/Azure/azure-sdk/master/_data/releases/latest/dotnet-packages.csv"
$BlobStorageUrl = "https://azuresdkdocs.blob.core.windows.net/%24web?restype=container&comp=list&prefix=dotnet%2F&delimiter=%2F"

function Get-dotnet-PackageInfoFromRepo ($pkgPath, $serviceDirectory)
{
  $projDirPath = (Join-Path $pkgPath "src")

  if (!(Test-Path $projDirPath))
  {
    return $null
  }

  $projectPaths = @(Resolve-Path (Join-Path $projDirPath "*.csproj"))
  
  if ($projectpaths.Count -ge 1) {
    $projectPath = $projectPaths[0].path
    if ($projectPaths.Count -gt 1) {
      LogWarning "There is more than on csproj file in the projectpath/src directory. First project picked."
    }
  }
  else {
    return $null
  }

  if ($projectPath -and (Test-Path $projectPath))
  {
    $pkgName = Split-Path -Path $projectPath -LeafBase 
    $projectData = New-Object -TypeName XML
    $projectData.load($projectPath)
    $pkgVersion = Select-XML -Xml $projectData -XPath '/Project/PropertyGroup/Version'
    $sdkType = "client"
    if ($pkgName -match "\.ResourceManager\." -or $pkgName -match "\.Management\.")
    {
      $sdkType = "mgmt"
    }
    $pkgProp = [PackageProps]::new($pkgName, $pkgVersion, $pkgPath, $serviceDirectory)
    $pkgProp.SdkType = $sdkType
    $pkgProp.IsNewSdk = $pkgName.StartsWith("Azure")
    $pkgProp.ArtifactName = $pkgName
    return $pkgProp
  }

  return $null
}

# Returns the nuget publish status of a package id and version.
function IsNugetPackageVersionPublished ($pkgId, $pkgVersion) 
{
  $nugetUri = "https://api.nuget.org/v3-flatcontainer/$($pkgId.ToLowerInvariant())/index.json"

  try
  {
    $nugetVersions = Invoke-RestMethod -MaximumRetryCount 3 -RetryIntervalSec 10 -uri $nugetUri -Method "GET"
    return $nugetVersions.versions.Contains($pkgVersion)
  }
  catch
  {
    $statusCode = $_.Exception.Response.StatusCode.value__
    $statusDescription = $_.Exception.Response.StatusDescription

    # if this is 404ing, then this pkg has never been published before
    if ($statusCode -eq 404) {
      return $False
    }

    Write-Host "Nuget Invocation failed:"
    Write-Host "StatusCode:" $statusCode
    Write-Host "StatusDescription:" $statusDescription
    exit(1)
  }
}

# Parse out package publishing information given a nupkg ZIP format.
function Get-dotnet-PackageInfoFromPackageFile ($pkg, $workingDirectory) 
{
  $workFolder = "$workingDirectory$($pkg.Basename)"
  $origFolder = Get-Location
  $zipFileLocation = "$workFolder/$($pkg.Basename).zip"
  $releaseNotes = ""
  $readmeContent = ""

  New-Item -ItemType Directory -Force -Path $workFolder

  Copy-Item -Path $pkg -Destination $zipFileLocation
  Expand-Archive -Path $zipFileLocation -DestinationPath $workFolder
  [xml] $packageXML = Get-ChildItem -Path "$workFolder/*.nuspec" | Get-Content
  $pkgId = $packageXML.package.metadata.id
  $docsReadMeName = $pkgId -replace "^Azure." , ""
  $pkgVersion = $packageXML.package.metadata.version

  $changeLogLoc = @(Get-ChildItem -Path $workFolder -Recurse -Include "CHANGELOG.md")[0]
  if ($changeLogLoc) 
  {
    $releaseNotes = Get-ChangeLogEntryAsString -ChangeLogLocation $changeLogLoc -VersionString $pkgVersion
  }

  $readmeContentLoc = @(Get-ChildItem -Path $workFolder -Recurse -Include "README.md")[0]
  if ($readmeContentLoc) 
  {
    $readmeContent = Get-Content -Raw $readmeContentLoc
  }

  Remove-Item $workFolder -Force  -Recurse -ErrorAction SilentlyContinue

  return New-Object PSObject -Property @{
    PackageId      = $pkgId
    PackageVersion = $pkgVersion
    ReleaseTag     = "$($pkgId)_$($pkgVersion)"
    Deployable     = $forceCreate -or !(IsNugetPackageVersionPublished -pkgId $pkgId -pkgVersion $pkgVersion)
    ReleaseNotes   = $releaseNotes
    ReadmeContent  = $readmeContent
    DocsReadMeName = $docsReadMeName
  }
}

# Return list of nupkg artifacts
function Get-dotnet-Package-Artifacts ($Location)
{
  $pkgs = Get-ChildItem "${Location}" -Recurse | Where-Object -FilterScript {$_.Name.EndsWith(".nupkg") -and -not $_.Name.EndsWith(".symbols.nupkg")}
  if (!$pkgs)
  {
    Write-Host "$($Location) does not have any package"
    return $null
  }
  elseif ($pkgs.Count -ne 1)
  {
    Write-Host "$($Location) should contain only one (1) published package"
    Write-Host "No of Packages $($pkgs.Count)"
    return $null
  }
  return $pkgs[0]
}

# Stage and Upload Docs to blob Storage
function Publish-dotnet-GithubIODocs ($DocLocation, $PublicArtifactLocation)
{
  $PublishedPkg = Get-dotnet-Package-Artifacts $DocLocation
  if (!$PublishedPkg)
  {
    Write-Host "Package is not available in artifact path $($DocLocation)"
    exit 1
  }

  $PublishedDocs = Get-ChildItem "${DocLocation}" | Where-Object -FilterScript {$_.Name.EndsWith("docs.zip")}

  if ($PublishedDoc.Count -gt 1)
  {
      Write-Host "$($DocLocation) should contain only one (1) published package and docs"
      Write-Host "No of Docs $($PublishedDoc.Count)"
      exit 1
  }

  $DocsStagingDir = "$WorkingDirectory/docstaging"
  $TempDir = "$WorkingDirectory/temp"

  New-Item -ItemType directory -Path $DocsStagingDir
  New-Item -ItemType directory -Path $TempDir

  Expand-Archive -LiteralPath $PublishedDocs[0].FullName -DestinationPath $DocsStagingDir
  $pkgProperties = Get-dotnet-PackageInfoFromPackageFile -pkg $PublishedPkg.FullName -workingDirectory $TempDir

  Write-Host "Start Upload for $($pkgProperties.ReleaseTag)"
  Write-Host "DocDir $($DocsStagingDir)"
  Write-Host "PkgName $($pkgProperties.PackageId)"
  Write-Host "DocVersion $($pkgProperties.PackageVersion)"
  Upload-Blobs -DocDir "$($DocsStagingDir)" -PkgName $pkgProperties.PackageId -DocVersion $pkgProperties.PackageVersion -ReleaseTag $pkgProperties.ReleaseTag
}

function Get-dotnet-GithubIoDocIndex()
{
  # Update the main.js and docfx.json language content
  UpdateDocIndexFiles -appTitleLang $LanguageDisplayName
  # Fetch out all package metadata from csv file.
  $metadata = Get-CSVMetadata -MetadataUri $MetadataUri
  # Get the artifacts name from blob storage
  $artifacts =  Get-BlobStorage-Artifacts -blobStorageUrl $BlobStorageUrl -blobDirectoryRegex "^dotnet/(.*)/$" -blobArtifactsReplacement '$1'
  # Build up the artifact to service name mapping for GithubIo toc.
  $tocContent = Get-TocMapping -metadata $metadata -artifacts $artifacts
  # Generate yml/md toc files and build site.
  GenerateDocfxTocContent -tocContent $tocContent -lang $LanguageDisplayName
}

# Details on CSV schema:
# https://review.docs.microsoft.com/en-us/help/onboard/admin/reference/dotnet/documenting-nuget?branch=master#set-up-the-ci-job
function Get-DocsCiConfig($configPath) {
  Write-Host "Loading csv from $configPath"
  $output = @()
  foreach ($row in Get-Content $configPath) { 
      $fields = $row.Split(',')

      $rawProperties = ''
      $packageProperties = @{}
      if ($fields[1] -match '\[(.*)\]') { 
          $rawProperties = $Matches[1] 
          foreach ($propertyExpression in $rawProperties.Split(';')) {
              $propertyParts = $propertyExpression.Split('=')
              $packageProperties[$propertyParts[0]] = $propertyParts[1]
          }
      }

      $packageName = '' 
      if ($fields[1] -match '(\[.*\])?(.*)') { 
          $packageName = $Matches[2] 
      } else { 
          Write-Error "Could not find package id in row: $row" 
      }

      $output += [PSCustomObject]@{
          Id = $fields[0];
          Name = $packageName;
          Properties = $packageProperties;
          Versions = ($fields | Select-Object -Skip 2)
      }
  }

  return $output
}

function Get-DocsCiLine ($item) { 
  $line = ''
  if ($item.Properties.Count) {
      $packageProperties = $item.Properties.Keys `
          | ForEach-Object { "$($_)=$($item.Properties[$_])" }
          | Join-String -Separator ';'
      $line = "$($item.Id),[$packageProperties]$($item.Name)"
  } else { 
      $line = "$($item.Id),$($item.Name)"
  }

  if ($item.Versions) { 
      $line += $item.Versions | Join-String -Separator ',' -OutputPrefix ','
  }

  return $line
}

function Update-dotnet-CIConfig($ciRepo, $locationInDocRepo)
{
  $publishedPackages = Get-CSVMetadata `
      | Where-Object { $_.New -eq 'true' -and $_.Hide -ne 'true' }

  # Update "Latest" packages
  $latestConfig = $locationInDocRepo `
    | Where-Object { $_.Mode -eq 'Latest' } `
    | Select-Object -First 1 
  $latestConfigPath = Join-Path $ciRepo $latestConfig.path_to_config -Resolve
  Write-Host "Updating latest configuration: $latestConfigPath"
  $latestPackages = Get-DocsCiConfig -configPath $latestConfigPath

  $latestPackageHash = @{} 
  foreach ($package in $latestPackages) { 
      # It's OK to have duplicate packages onboarded. This algortihm requires that
      # the package is onboarded at least once in the onboarding csv file
      $latestPackageHash[$package.Name] = $true 
  }

  $gaPackages = $publishedPackages | Where-Object { $_.VersionGA.Trim() -ne '' }
  foreach ($package in $gaPackages) { 
      if ($latestPackageHash.ContainsKey($package.Package)) { 
          # Onboarded packages already contains this package, skip
          Write-Host "Skipping already onboarded package: $($package.Package)"
          continue
      }

      Write-Host "Adding latest package: $($package.Package)"
      $latestPackages += [PSCustomObject]@{
          Id = $package.Package.ToLower().Replace('.', '');
          Name = $package.Package;
          Properties = @{ tfm = 'netstandard2.0'; };
          Versions = @()
      }
  }

  $latestPackages `
    | ForEach-Object { Get-DocsCiLine $_ } `
    | Set-Content $latestConfigPath


  # Update "Preview" packages
  $previewConfig = $previewConfig = $locationInDocRepo `
    | Where-Object { $_.Mode -eq 'Preview' } `
    | Select-Object -First 1 
  $previewConfigPath = Join-Path $ciRepo $previewConfig.path_to_config -Resolve
  Write-Host "Updating preview configuration: $previewConfigPath"
  $previewPackages = Get-DocsCiConfig -configPath $previewConfigPath

  $outputPackages = @()
  foreach ($package in $previewPackages) { 
      $matchingMetadataPackages = $publishedPackages `
        | Where-Object { $_.Package -eq $package.Name }
      
      # If this package does not match any published packages keep it in the list
      if (-not $matchingMetadataPackages) {
          Write-Host "Retaining non-tracked preview package: $($package.Name)"
          $outputPackages += $package
          continue
      }

      # If there is a preview version of the package
      if ($matchingMetadataPackages | Where-Object { $_.VersionPreview.Trim() -ne '' }) {
          Write-Host "Keeping tracked preview package: $($package.Name)"
          $outputPackages += $package 
      } else { 
        Write-Host "Removing superseded package: $($package.Name)"
      }
  }

  $outputPackagesHash = @{}
  foreach ($package in $outputPackages) { 
      $outputPackagesHash[$package.Name] = $true
  }

  $remainingPreviewPackages = $publishedPackages `
      | Where-Object { 
          $_.VersionPreview.Trim() -ne '' `
          -and (-not $outputPackagesHash.ContainsKey($_.Package))
      }

  foreach ($package in $remainingPreviewPackages) {
    Write-Host "Adding tracked preview package: $($package.Package)"
    $outputPackages += [PSCustomObject]@{
        Id = $package.Package.ToLower().Replace('.', '');
        Name = $package.Package;
        Properties = @{ tfm = 'netstandard2.0'; isPrerelease = 'true' };
        Versions = @()
    }
  }

  $outputPackages `
    | ForEach-Object { Get-DocsCiLine $_ } `
    | Set-Content $previewConfigPath
}

# function is used to auto generate API View
function Find-dotnet-Artifacts-For-Apireview($artifactDir, $packageName)
{
  # Find all nupkg files in given artifact directory
  $PackageArtifactPath = Join-Path $artifactDir $packageName
  $pkg = Get-dotnet-Package-Artifacts $PackageArtifactPath
  if (!$pkg)
  {
    Write-Host "Package is not available in artifact path $($PackageArtifactPath)"
    return $null
  }
  $packages = @{ $pkg.Name = $pkg.FullName }
  return $packages
}

function SetPackageVersion ($PackageName, $Version, $ServiceDirectory, $ReleaseDate)
{
  if($null -eq $ReleaseDate)
  {
    $ReleaseDate = Get-Date -Format "yyyy-MM-dd"
  }
  & "$EngDir/scripts/Update-PkgVersion.ps1" -ServiceDirectory $ServiceDirectory -PackageName $PackageName `
  -NewVersionString $Version -ReleaseDate $ReleaseDate
}

function GetExistingPackageVersions ($PackageName, $GroupId=$null)
{
  try {
    $existingVersion = Invoke-RestMethod -Method GET -Uri "https://api.nuget.org/v3-flatcontainer/${PackageName}/index.json"
    return $existingVersion.versions
  }
  catch {
    LogError "Failed to retrieve package versions. `n$_"
    return $null
  }
}
