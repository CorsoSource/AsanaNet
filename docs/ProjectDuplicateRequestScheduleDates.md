# AsanaNet.Model.ProjectDuplicateRequestScheduleDates
A dictionary of options to auto-shift dates. `task_dates` must be included to use this option. Requires either `start_on` or `due_on`, but not both.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShouldSkipWeekends** | **bool** | Determines if the auto-shifted dates should skip weekends. | 
**DueOn** | **string** | Sets the last due date in the duplicated project to the given date. The rest of the due dates will be offset by the same amount as the due dates in the original project. | [optional] 
**StartOn** | **string** | Sets the first start date in the duplicated project to the given date. The rest of the start dates will be offset by the same amount as the start dates in the original project. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

