# AsanaNet.Model.UserResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | *Read-only except when same user as requester*. The user’s name. | [optional] 
**Email** | **string** | The user&#39;s email address. | [optional] [readonly] 
**Photo** | [**UserBaseResponseAllOfPhoto**](UserBaseResponseAllOfPhoto.md) |  | [optional] 
**Workspaces** | [**List&lt;WorkspaceCompact&gt;**](WorkspaceCompact.md) | Workspaces and organizations this user may access. Note\\: The API will only return workspaces and organizations that also contain the authenticated user. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

