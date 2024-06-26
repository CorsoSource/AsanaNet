# AsanaNet.Model.TimeTrackingEntryBase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**DurationMinutes** | **int** | Time in minutes tracked by the entry. | [optional] 
**EnteredOn** | **DateTime** | The day that this entry is logged on. | [optional] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**Task** | [**TaskCompact**](TaskCompact.md) |  | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

