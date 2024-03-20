# AsanaNet.Model.WebhookCompact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Active** | **bool** | If true, the webhook will send events - if false it is considered inactive and will not generate events. | [optional] [readonly] 
**Resource** | [**AsanaNamedResource**](AsanaNamedResource.md) |  | [optional] 
**Target** | **string** | The URL to receive the HTTP POST. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

