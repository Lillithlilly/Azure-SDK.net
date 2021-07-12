# Azure.Ccap.Communication.Router
When a new version of the swagger needs to be updated:
1. Go to sdk\communication, and run `dotnet msbuild /t:GenerateCode` to generate code.
2. Upload the Azure.Communication.Chat.dll to the apiview.dev tool.
If any of the new objects needs to be overwritten, add the required changes to the 'Models' folder.

3. Repeat 2 and 3 until the desided interface is reflected in the apiview.dev 

> see [https://aka.ms/autorest](https://aka.ms/autorest)


Run following command to generate router sdk instead of running GenerateCode. It resolves polymorphic issue by 
specifying the autorest core version.

autorest ./autorest.md --csharp --version=3.0.6267 --v3



## Configuration

```yaml
input-file: http://localhost:5000/swagger/2021-04-07/swagger.json

csharp:
  azure-arm: true
  license-header: MICROSOFT_MIT_NO_VERSION
  payload-flattening-threshold: 10
  clear-output-folder: true
  client-side-validation: false
  namespace: Microsoft.CommunicationServices
  output-folder: $(csharp-sdks-folder)/communicationservices/management/Microsoft.CommunicationServices/GeneratedProtocol

openapi-type: data-plane
tag: V2021_04_07_preview1

title:
  Azure Communication Services

directive:
  - from: swagger-document  
    where: "$.components.schemas.CreateDistributionPolicyRequest.properties.mode"
    transform: >
      $["$ref"] = "#/components/schemas/ModePolicy";
  - from: swagger-document
    where: "$.components.schemas.CreateDistributionPolicyRequest.properties.filter"
    transform: >
      $["$ref"] = "#/components/schemas/FilterPolicy";

  - from: swagger-document
    where: "$.components.schemas.UpdateDistributionPolicyRequest.properties.mode"
    transform: >
      $["$ref"] = "#/components/schemas/ModePolicy";
  - from: swagger-document
    where: "$.components.schemas.UpdateDistributionPolicyRequest.properties.filter"
    transform: >
      $["$ref"] = "#/components/schemas/FilterPolicy";
      
  - from: swagger-document
    where: "$.components.schemas.DistributionPolicy.properties.mode"
    transform: >
      $["$ref"] = "#/components/schemas/ModePolicy";
  - from: swagger-document
    where: "$.components.schemas.DistributionPolicy.properties.filter"
    transform: >
      $["$ref"] = "#/components/schemas/FilterPolicy";

  - from: swagger-document
    where: "$.components.schemas.CompositeModeIteration.properties.mode"
    transform: >
      $["$ref"] = "#/components/schemas/ModePolicy";
      
  - from: swagger-document
    where: "$.components.schemas.CompositeFilterPolicy.properties.filters.items"
    transform: >
      $["$ref"] = "#/components/schemas/FilterPolicy";
      
  - from: swagger-document
    where: "$.components.schemas.CreateClassificationPolicyRequest.properties.queueSelectionRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.CreateClassificationPolicyRequest.properties.workerAbilityRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.CreateClassificationPolicyRequest.properties.prioritizationRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";

  - from: swagger-document
    where: "$.components.schemas.ClassificationPolicy.properties.queueSelectionRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.ClassificationPolicy.properties.workerAbilityRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.ClassificationPolicy.properties.prioritizationRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";


  - from: swagger-document
    where: "$.components.schemas.UpdateClassificationPolicyRequest.properties.queueSelectionRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.UpdateClassificationPolicyRequest.properties.workerAbilityRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";
  - from: swagger-document
    where: "$.components.schemas.UpdateClassificationPolicyRequest.properties.prioritizationRules"
    transform: >
      $["$ref"] = "#/components/schemas/RuleContainer";  

  - from: swagger-document
    where: "$.components.schemas.ExceptionRule.properties.trigger"
    transform: >
      $["$ref"] = "#/components/schemas/ExceptionTrigger";     
  - from: swagger-document
    where: "$.components.schemas.ExceptionRule.properties.action"
    transform: >
      $["$ref"] = "#/components/schemas/ExceptionAction"; 

  - from: swagger-document
    where: "$.components.schemas.CompositeExceptionTrigger.properties.exceptionTriggers.items"
    transform: >
      $["$ref"] = "#/components/schemas/ExceptionTrigger"; 
  - from: swagger-document
    where: "$.components.schemas.CompositeExceptionAction.properties.exceptionActions.items"
    transform: >
      $["$ref"] = "#/components/schemas/ExceptionAction"; 
      
  - from: swagger-document
    where: "$.components.schemas.RegisterWorkerRequest.properties.queueAssignments.items"
    transform: >
      $["$ref"] = "#/components/schemas/QueueAssignment";  

  - from: swagger-document
    where: "$.components.schemas.Worker.properties.queueAssignments.items"
    transform: >
      $["$ref"] = "#/components/schemas/QueueAssignment";  


  - from: swagger-document
    where: "$.components.schemas.RuleContainer.properties.objectType"
    transform: >
      $["readOnly"] = false 

  - from: swagger-document
    where: "$.components.schemas.ModePolicy.properties.objectType"
    transform: >
      $["readOnly"] = false 
      
  - from: swagger-document
    where: "$.components.schemas.FilterPolicy.properties.objectType"
    transform: >
      $["readOnly"] = false 
      
  - from: swagger-document
    where: "$.components.schemas.ExceptionTrigger.properties.objectType"
    transform: >
      $["readOnly"] = false 
      
  - from: swagger-document
    where: "$.components.schemas.ExceptionAction.properties.objectType"
    transform: >
      $["readOnly"] = false 
      
  - from: swagger-document
    where: "$.components.schemas.QueueAssignment.properties.objectType"
    transform: >
      $["readOnly"] = false 
      
  - from: swagger-document
    where: "$.components.schemas.TimeSpan"
    transform: >
      $["type"] = string       

```

