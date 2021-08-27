# Microsoft.Azure.Synapse.Artifacts

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
#tag: package-artifacts-2019-06-01-preview
tag: package-artifacts-2020-12-01
#tag: package-artifacts-2021-06-01-preview
require:
#    - https://github.com/Azure/azure-rest-api-specs/blob/fc5e2fbcfc3f585d38bdb1c513ce1ad2c570cf3d/specification/synapse/data-plane/readme.md
#    - https://github.com/Azure/azure-rest-api-specs/blob/01f98f0f3f1e9ba27db8c0d0bcc5ee3f267fd162/specification/synapse/data-plane/readme.md
#    - https://github.com/Azure/azure-rest-api-specs/blob/3257aacc47c2a03b7964cbb5c6a07ec9f2f232ee/specification/synapse/data-plane/readme.md
 - C:\src\swagger_azure-rest-api-specs\specification\synapse\data-plane\readme.md
namespace: Azure.Analytics.Synapse.Artifacts
public-clients: true
security: AADToken
security-scopes: https://dev.azuresynapse.net/.default
modelerfour:
  lenient-model-deduplication: true
```

### Make Endpoint type as Uri

``` yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: $.format = "url"
```

### Expose serialization and deserialization methods and internal models

``` yaml
directive:
- from: swagger-document
  where: $.definitions
  transform: >
    for (var path in $)
    {
      if (path.endsWith("AvroFormat") ||
          path.endsWith("CreateDataFlowDebugSessionRequest") ||
          path.endsWith("CopyBehaviorType") ||
          path.endsWith("CopyTranslator") ||
          path.endsWith("DataFlowDebugPreviewDataRequest") ||
          path.endsWith("DataFlowDebugQueryResponse") ||
          path.endsWith("DataFlowDebugResultResponse") ||
          path.endsWith("DataFlowDebugStatisticsRequest") ||
          path.endsWith("DataFlowDebugPackage") ||
          path.endsWith("DatasetDataElement") ||
          path.endsWith("DatasetSchemaDataElement") ||
          path.endsWith("DatasetStorageFormat") ||
          path.endsWith("EvaluateDataFlowExpressionRequest") ||
          path.endsWith("ExposureControlRequest") ||
          path.endsWith("ExposureControlResponse") ||
          path.endsWith("GetSsisObjectMetadataRequest") ||
          path.endsWith("JsonFormat") ||
          path.endsWith("JsonFormatFilePattern") ||
          path.endsWith("OrcFormat") ||
          path.endsWith("ParquetFormat") ||
          path.endsWith("RerunTriggerListResponse") ||
          path.endsWith("RerunTumblingWindowTriggerActionParameter") ||
          path.endsWith("SsisObjectMetadataStatusResponse") ||
          path.endsWith("StartDataFlowDebugSessionRequest") ||
          path.endsWith("StartDataFlowDebugSessionResponse") ||
          path.endsWith("TabularTranslator") ||
          path.endsWith("TextFormat") ||
          path.endsWith("TriggerDependencyProvisioningStatus") ||
          path.endsWith("TypeConversionSettings") ||
          path.endsWith("WorkspaceIdentity") ||
          path.endsWith("WorkspaceUpdateParameters"))
      {
        $[path]["x-csharp-usage"] = "model,input,output,converter";
        $[path]["x-csharp-formats"] = "json";
      }
      else
      {
        $[path]["x-csharp-usage"] = "converter";
      }
    }
```

### Make expression object types into strings
``` yaml
directive:
  from: swagger-document
  where: $.definitions.DatasetCompression
  transform: $.type = "string"
```
