# AsanaNet.Model.TeamResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the team. | [optional] 
**Description** | **string** | [Opt In](/docs/inputoutput-options). The description of the team.  | [optional] 
**HtmlDescription** | **string** | [Opt In](/docs/inputoutput-options). The description of the team with formatting as HTML.  | [optional] 
**Organization** | [**TeamResponseAllOfOrganization**](TeamResponseAllOfOrganization.md) |  | [optional] 
**PermalinkUrl** | **string** | A url that points directly to the object within Asana. | [optional] [readonly] 
**Visibility** | **string** | The visibility of the team to users in the same organization  | [optional] 
**EditTeamNameOrDescriptionAccessLevel** | **string** | Controls who can edit team name and description  | [optional] [readonly] 
**EditTeamVisibilityOrTrashTeamAccessLevel** | **string** | Controls who can edit team visibility and trash teams  | [optional] [readonly] 
**MemberInviteManagementAccessLevel** | **string** | Controls who can accept or deny member invites for a given team  | [optional] [readonly] 
**GuestInviteManagementAccessLevel** | **string** | Controls who can accept or deny guest invites for a given team  | [optional] [readonly] 
**JoinRequestManagementAccessLevel** | **string** | Controls who can accept or deny join team requests for a Membership by Request team  | [optional] [readonly] 
**TeamMemberRemovalAccessLevel** | **string** | Controls who can remove team members  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

