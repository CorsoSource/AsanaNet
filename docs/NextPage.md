# AsanaNet.Model.NextPage
*Conditional*. This property is only present when a limit query parameter is provided in the request. When making a paginated request, the API will return a number of results as specified by the limit parameter. If more results exist, then the response will contain a next_page attribute, which will include an offset, a relative path attribute, and a full uri attribute. If there are no more pages available, next_page will be null and no offset will be provided. Note that an offset token will expire after some time, as data may have changed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Offset** | **string** | Pagination offset for the request. | [optional] [readonly] 
**Path** | **string** | A relative path containing the query parameters to fetch for next_page | [optional] [readonly] 
**Uri** | **string** | A full uri containing the query parameters to fetch for next_page | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

