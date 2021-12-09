param(
  [string]$PackagesPath,
  [string]$DepsOutputFile,
  [string]$ProjectRefPath
)

mkdir $ProjectRefPath -force | out-null
$projRefsPath = Join-Path $ProjectRefPath "azure-sdk-projectreferences.props"

$ignoreList = @(
  "Azure.Monitor.OpenTelemetry.Exporter",
  "Microsoft.Azure.Messaging.EventGrid.CloudNativeCloudEvents"
)

$projectRefsContents = @"
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <ItemGroup>

"@

foreach ($pkg in (Get-ChildItem "$PackagesPath/*" -Include *.nupkg -Exclude *.symbols.nupkg))
{
  if ($pkg.Name -match "(?<pkg>[^\\]+)\.(?<ver>\d+\.\d+\.\d+.*)\.nupkg") 
  {
    if ($matches['pkg'] -notin $ignoreList)
    {
      $projectRefsContents += "    <PackageReference Include=`"$($matches['pkg'])`" Version=`"$($matches['ver'])`" />`n"
    }
  }
}

$projectRefsContents += @"
  </ItemGroup>
</Project>
"@

Set-Content -Path $projRefsPath -Value $projectRefsContents

$cmd = "dotnet build $PSScriptRoot/azure-sdk.deps.csproj /t:GenerateDepsFile /p:PublishDepsFilePath=""$DepsOutputFile"" /p:AzureSdkProjectReferencesPath=""$projRefsPath"" /p:RestoreAdditionalProjectSources=""$PackagesPath"""
Write-Host $cmd
Invoke-Expression $cmd