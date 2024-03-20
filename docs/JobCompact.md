# AsanaNet.Model.JobCompact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**ResourceSubtype** | **string** | The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. | [optional] [readonly] 
**Status** | **string** | The current status of this job. The value is one of: &#x60;not_started&#x60;, &#x60;in_progress&#x60;, &#x60;succeeded&#x60;, or &#x60;failed&#x60;. | [optional] [readonly] 
**NewProject** | [**ProjectCompact**](ProjectCompact.md) |  | [optional] 
**NewTask** | [**JobCompactAllOfNewTask**](JobCompactAllOfNewTask.md) |  | [optional] 
**NewProjectTemplate** | [**ProjectTemplateCompact**](ProjectTemplateCompact.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

