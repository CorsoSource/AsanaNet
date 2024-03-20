# AsanaNet.Model.GetEvents200Response
The full record for all events that have occurred since the sync token was created.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;EventResponse&gt;**](EventResponse.md) |  | [optional] 
**Sync** | **string** | A sync token to be used with the next call to the /events endpoint. | [optional] 
**HasMore** | **bool** | Indicates whether there are more events to pull. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

