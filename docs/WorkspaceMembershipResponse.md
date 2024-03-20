# AsanaNet.Model.WorkspaceMembershipResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**User** | [**UserCompact**](UserCompact.md) |  | [optional] 
**Workspace** | [**WorkspaceCompact**](WorkspaceCompact.md) |  | [optional] 
**UserTaskList** | [**UserTaskListCompact**](UserTaskListCompact.md) |  | [optional] 
**IsActive** | **bool** | Reflects if this user still a member of the workspace. | [optional] [readonly] 
**IsAdmin** | **bool** | Reflects if this user is an admin of the workspace. | [optional] [readonly] 
**IsGuest** | **bool** | Reflects if this user is a guest of the workspace. | [optional] [readonly] 
**VacationDates** | [**WorkspaceMembershipResponseAllOfVacationDates**](WorkspaceMembershipResponseAllOfVacationDates.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

