# AsanaNet.Model.ProjectBaseAllOfCurrentStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Title** | **string** | The title of the project status update. | [optional] 
**Text** | **string** | The text content of the status update. | [optional] 
**HtmlText** | **string** | [Opt In](/docs/inputoutput-options). The text content of the status update with formatting as HTML. | [optional] 
**Color** | **string** | The color associated with the status update. | [optional] 
**Author** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**ModifiedAt** | **DateTime** | The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the project status.* | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

