# AsanaNet.Model.WorkspaceMembershipResponseAllOfVacationDates
Contains keys `start_on` and `end_on` for the vacation dates for the user in this workspace. If `start_on` is null, the entire `vacation_dates` object will be null. If `end_on` is before today, the entire `vacation_dates` object will be null.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartOn** | **string** | The day on which the user&#39;s vacation in this workspace starts. This is a date with &#x60;YYYY-MM-DD&#x60; format. | [optional] 
**EndOn** | **string** | The day on which the user&#39;s vacation in this workspace ends, or null if there is no end date. This is a date with &#x60;YYYY-MM-DD&#x60; format. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

