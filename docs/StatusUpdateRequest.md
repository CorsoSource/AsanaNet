# AsanaNet.Model.StatusUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Title** | **string** | The title of the status update. | [optional] 
**ResourceSubtype** | **string** | The subtype of this resource. Different subtypes retain many of the same fields and behavior, but may render differently in Asana or represent resources with different semantic meaning. The &#x60;resource_subtype&#x60;s for &#x60;status&#x60; objects represent the type of their parent. | [optional] [readonly] 
**Text** | **string** | The text content of the status update. | 
**HtmlText** | **string** | [Opt In](/docs/inputoutput-options). The text content of the status update with formatting as HTML. | [optional] 
**StatusType** | **string** | The type associated with the status update. This represents the current state of the object this object is on. | 
**Parent** | **string** | The id of parent to send this status update to. This can be a project, goal or portfolio. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

