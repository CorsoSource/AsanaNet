# AsanaNet.Model.BatchResponse
A response object returned from a batch request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusCode** | **int** | The HTTP status code that the invoked endpoint returned. | [optional] 
**Headers** | **Object** | A map of HTTP headers specific to this result. This is primarily used for returning a &#x60;Location&#x60; header to accompany a &#x60;201 Created&#x60; result.  The parent HTTP response will contain all common headers. | [optional] 
**Body** | **Object** | The JSON body that the invoked endpoint returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

