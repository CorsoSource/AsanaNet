# AsanaNet.Model.GoalMembershipCompact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] 
**ResourceSubtype** | **string** | The type of membership. | [optional] [readonly] 
**Member** | [**MemberCompact**](MemberCompact.md) |  | [optional] 
**Parent** | [**GoalMembershipBaseAllOfParent**](GoalMembershipBaseAllOfParent.md) |  | [optional] 
**Role** | **string** | Describes if the member is a commenter or editor in goal. | [optional] 
**Goal** | [**GoalMembershipBaseAllOfGoal**](GoalMembershipBaseAllOfGoal.md) |  | [optional] 
**IsCommenter** | **bool** | *Deprecated: new integrations should prefer the &#x60;role&#x60; field.* Describes if the member is comment only in goal. | [optional] [readonly] 
**IsEditor** | **bool** | *Deprecated: new integrations should prefer the &#x60;role&#x60; field.* Describes if the member is editor in goal. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

