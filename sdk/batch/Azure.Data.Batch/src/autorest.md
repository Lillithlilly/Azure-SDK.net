# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- E:\hpc\azure-rest-api-specs\specification\batch\data-plane\Microsoft.Batch\stable\2022-01-01.15.0\BatchService.json
namespace: Azure.Data.Batch
public-clients: true
data-plane: true
security: AADToken
security-scopes: https://batch.core.windows.net/.default
 
```
