# AsanaNet.Model.GoalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the goal. | [optional] 
**HtmlNotes** | **string** | The notes of the goal with formatting as HTML. | [optional] 
**Notes** | **string** | Free-form textual information associated with the goal (i.e. its description). | [optional] 
**DueOn** | **string** | The localized day on which this goal is due. This takes a date with format &#x60;YYYY-MM-DD&#x60;. | [optional] 
**StartOn** | **string** | The day on which work for this goal begins, or null if the goal has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format, and cannot be set unless there is an accompanying due date. | [optional] 
**IsWorkspaceLevel** | **bool** | *Conditional*. This property is only present when the &#x60;workspace&#x60; provided is an organization. Whether the goal belongs to the &#x60;workspace&#x60; (and is listed as part of the workspace’s goals) or not. If it isn’t a workspace-level goal, it is a team-level goal, and is associated with the goal’s team. | [optional] 
**Liked** | **bool** | True if the goal is liked by the authorized user, false if not. | [optional] 
**Likes** | [**List&lt;Like&gt;**](Like.md) | Array of likes for users who have liked this goal. | [optional] [readonly] 
**NumLikes** | **int** | The number of users who have liked this goal. | [optional] [readonly] 
**Team** | [**GoalResponseAllOfTeam**](GoalResponseAllOfTeam.md) |  | [optional] 
**Workspace** | [**GoalResponseAllOfWorkspace**](GoalResponseAllOfWorkspace.md) |  | [optional] 
**Followers** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users who are members of this goal. | [optional] 
**TimePeriod** | [**GoalResponseAllOfTimePeriod**](GoalResponseAllOfTimePeriod.md) |  | [optional] 
**Metric** | [**GoalResponseAllOfMetric**](GoalResponseAllOfMetric.md) |  | [optional] 
**Owner** | [**GoalResponseAllOfOwner**](GoalResponseAllOfOwner.md) |  | [optional] 
**CurrentStatusUpdate** | [**GoalResponseAllOfCurrentStatusUpdate**](GoalResponseAllOfCurrentStatusUpdate.md) |  | [optional] 
**Status** | **string** | The current status of this goal. When the goal is open, its status can be &#x60;green&#x60;, &#x60;yellow&#x60;, and &#x60;red&#x60; to reflect \&quot;On Track\&quot;, \&quot;At Risk\&quot;, and \&quot;Off Track\&quot;, respectively. When the goal is closed, the value can be &#x60;missed&#x60;, &#x60;achieved&#x60;, &#x60;partial&#x60;, or &#x60;dropped&#x60;. *Note* you can only write to this property if &#x60;metric&#x60; is set. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

