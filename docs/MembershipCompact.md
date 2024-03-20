# AsanaNet.Model.MembershipCompact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] 
**ResourceSubtype** | **string** | Type of the membership. | [optional] 
**Member** | [**MemberCompact**](MemberCompact.md) |  | [optional] 
**Parent** | [**ProjectCompact**](ProjectCompact.md) |  | [optional] 
**Role** | **string** | Describes if the member is a commenter or editor in goal. | [optional] 
**Goal** | [**GoalMembershipBaseAllOfGoal**](GoalMembershipBaseAllOfGoal.md) |  | [optional] 
**IsCommenter** | **bool** | *Deprecated: new integrations should prefer the &#x60;role&#x60; field.* Describes if the member is comment only in goal. | [optional] [readonly] 
**IsEditor** | **bool** | *Deprecated: new integrations should prefer the &#x60;role&#x60; field.* Describes if the member is editor in goal. | [optional] [readonly] 
**AccessLevel** | **string** | Whether the member has admin, editor, commenter, or viewer access to the project. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

