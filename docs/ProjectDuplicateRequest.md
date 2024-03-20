# AsanaNet.Model.ProjectDuplicateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the new project. | 
**Team** | **string** | Sets the team of the new project. If team is not defined, the new project will be in the same team as the the original project. | [optional] 
**Include** | **string** | A comma-separated list of elements that will be duplicated to the new project. Tasks are always included. ##### Fields - allocations - forms - members - notes - task_assignee - task_attachments - task_dates - task_dependencies - task_followers - task_notes - task_projects - task_subtasks - task_tags | [optional] 
**ScheduleDates** | [**ProjectDuplicateRequestScheduleDates**](ProjectDuplicateRequestScheduleDates.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

