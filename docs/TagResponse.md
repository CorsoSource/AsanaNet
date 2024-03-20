# AsanaNet.Model.TagResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the tag. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer. | [optional] 
**Color** | **string** | Color of the tag. | [optional] 
**Notes** | **string** | Free-form textual information associated with the tag (i.e. its description). | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**Followers** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users following this tag. | [optional] [readonly] 
**Workspace** | [**WorkspaceCompact**](WorkspaceCompact.md) |  | [optional] 
**PermalinkUrl** | **string** | A url that points directly to the object within Asana. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

