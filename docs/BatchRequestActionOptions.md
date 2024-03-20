# AsanaNet.Model.BatchRequestActionOptions
Pagination (`limit` and `offset`) and output options (`fields` or `expand`) for the action. “Pretty” JSON output is not an available option on individual actions; if you want pretty output, specify that option on the parent request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **int** | Pagination limit for the request. | [optional] 
**Offset** | **int** | Pagination offset for the request. | [optional] 
**Fields** | **List&lt;string&gt;** | The fields to retrieve in the request. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

