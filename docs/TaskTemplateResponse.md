# AsanaNet.Model.TaskTemplateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the task template. | [optional] 
**Project** | [**TaskTemplateResponseAllOfProject**](TaskTemplateResponseAllOfProject.md) |  | [optional] 
**Template** | [**TaskTemplateRecipe**](TaskTemplateRecipe.md) | The configuration for the task that will be created from this template. | [optional] 
**CreatedBy** | [**UserCompact**](UserCompact.md) | The user who created this task template. | [optional] 
**CreatedAt** | **DateTime** | The time at which this task template was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

