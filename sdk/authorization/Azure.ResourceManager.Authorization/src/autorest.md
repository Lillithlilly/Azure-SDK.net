# Generated code configuration

Run `dotnet build /t:GenerateCode` to generate code.

# Azure.ResourceManager.Authorization

> see https://aka.ms/autorest

``` yaml
azure-arm: true
library-name: Authorization
namespace: Azure.ResourceManager.Authorization
require: https://github.com/Azure/azure-rest-api-specs/blob/ec2b6d1985ce89c8646276e0806a738338e98bd2/specification/authorization/resource-manager/readme.md
tag: package-2020-10-01-preview
clear-output-folder: true
skip-csproj: true
modelerfour:
  lenient-model-deduplication: true

#TODO: remove after we resolve why RestorePoint has no list
list-exception:
- /providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}

request-path-to-resource-name:
  /subscriptions/{subscriptionId}/providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}: AccessReviewInstance
  /providers/Microsoft.Authorization/accessReviewScheduleDefinitions/{scheduleDefinitionId}/instances/{id}: AccessReviewScheduleDefinitionInstance
mgmt-debug:
  show-request-path: true
directive:

  - remove-operation: DenyAssignments_GetById
  - remove-operation: RoleAssignments_GetById
  - remove-operation: RoleAssignments_CreateById
  - remove-operation: RoleAssignments_DeleteById

  - from: swagger-document
    where: $["x-ms-paths"]
    transform: delete $["/{roleId}?disambiguation_dummy"]
```
