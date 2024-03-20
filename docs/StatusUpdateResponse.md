# AsanaNet.Model.StatusUpdateResponse

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
**Author** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**Hearted** | **bool** | *Deprecated - please use liked instead* True if the status is hearted by the authorized user, false if not. | [optional] [readonly] 
**Hearts** | [**List&lt;Like&gt;**](Like.md) | *Deprecated - please use likes instead* Array of likes for users who have hearted this status. | [optional] [readonly] 
**Liked** | **bool** | True if the status is liked by the authorized user, false if not. | [optional] 
**Likes** | [**List&lt;Like&gt;**](Like.md) | Array of likes for users who have liked this status. | [optional] [readonly] 
**ModifiedAt** | **DateTime** | The time at which this project status was last modified. *Note: This does not currently reflect any changes in associations such as comments that may have been added or removed from the status.* | [optional] [readonly] 
**NumHearts** | **int** | *Deprecated - please use likes instead* The number of users who have hearted this status. | [optional] [readonly] 
**NumLikes** | **int** | The number of users who have liked this status. | [optional] [readonly] 
**Parent** | [**StatusUpdateResponseAllOfParent**](StatusUpdateResponseAllOfParent.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

