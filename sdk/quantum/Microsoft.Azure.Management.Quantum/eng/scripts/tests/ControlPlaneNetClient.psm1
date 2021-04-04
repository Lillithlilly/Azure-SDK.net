########################################################################################################
# Do NOT modify this section as it will get replaced by the base class defined in
# https://github.com/microsoft/azure-quantum-clients/blob/tests/common/ControlPlaneBaseClient.psm1
# Start of "do NOT modify section"
########################################################################################################

class ControlPlaneBaseClient
{
    ControlPlaneBaseClient()
    {
        $type = $this.GetType()

        if ($type -eq [ControlPlaneBaseClient])
        {
            throw("Class $type must be inherited")
        }
    }

    Prepare(
        [string]$PackageVersion
        ,[bool]$AllowPreRelease = $true)
    {
        throw("Must Override Method")        
    }

    CreateWorkspace(
        [string]$SubscriptionId
        ,[string]$ResourceGroup
        ,[string]$Location
        ,[string]$StorageAccount
        ,[string]$WorkspaceName)
    {
        throw("Must Override Method")
    }
}

########################################################################################################
# End of "do NOT modify section"
########################################################################################################


class ControlPlaneNetClient : ControlPlaneBaseClient
{
    Prepare(
        [string]$PackageVersion
        ,[bool]$AllowPreRelease = $true)
    {
        $TestProjectRoot = Join-Path $PSScriptRoot "../../../tests/" -Resolve

        Push-Location $TestProjectRoot
        try {
            if (![string]::IsNullOrEmpty($PackageVersion)){
                dotnet remove reference "..\src\Microsoft.Azure.Management.Quantum.csproj"
                dotnet remove package Microsoft.Azure.Management.Quantum
                if ([string]::Equals("latest", $PackageVersion)) {
                    if ($AllowPreRelease) {
                        dotnet add package Microsoft.Azure.Management.Quantum --prerelease
                    }
                    else {
                        dotnet add package Microsoft.Azure.Management.Quantum
                    }    
                }
                else {
                    dotnet add package Microsoft.Azure.Management.Quantum --version=$PackageVersion
                }
            } 
            else {
                dotnet remove package Microsoft.Azure.Management.Quantum
                dotnet add reference "..\src\Microsoft.Azure.Management.Quantum.csproj"
            }
        }
        finally {
            Pop-Location
        }
    }

    CreateWorkspace(
        [string]$SubscriptionId
        ,[string]$ResourceGroup
        ,[string]$Location
        ,[string]$StorageAccount
        ,[string]$WorkspaceName)
    {
        $env:AZURE_TEST_MODE = "Record"
        Write-Verbose "Setting Azure SDK Test Mode to: $env:AZURE_TEST_MODE"

        $env:QUANTUM_E2E_TESTS = "1"
        Write-Verbose "Setting QUANTUM_E2E_TESTS to: $env:QUANTUM_E2E_TESTS"
        
        Write-Verbose "Creating workspace via ControlPlane .NET Client"
        Write-Verbose "  SubscriptionId: $SubscriptionId"
        Write-Verbose "  ResourceGroup: $ResourceGroup"
        Write-Verbose "  Location: $Location"
        Write-Verbose "  StorageAccount: $StorageAccount"
        Write-Verbose "  WorkspaceName: $WorkspaceName"

        $env:SUBSCRIPTION_ID = $SubscriptionId
        $env:RESOURCE_GROUP = $ResourceGroup
        $env:LOCATION = $Location
        $env:STORAGE_ACCOUNT = $StorageAccount
        $env:QUANTUM_WORKSPACE_NAME = $WorkspaceName
    
        $TestProjectRoot = Join-Path $PSScriptRoot "../../../tests/" -Resolve

        Push-Location $TestProjectRoot
        try {
            dotnet test --filter "FullyQualifiedName=Microsoft.Azure.Management.Quantum.Tests.WorkspaceOperationTests.TestCreateWorkspace"            
        }
        finally {
            Pop-Location
        }
    }
}
