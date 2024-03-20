# AsanaNet.Model.WebhookResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Active** | **bool** | If true, the webhook will send events - if false it is considered inactive and will not generate events. | [optional] [readonly] 
**Resource** | [**AsanaNamedResource**](AsanaNamedResource.md) |  | [optional] 
**Target** | **string** | The URL to receive the HTTP POST. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**LastFailureAt** | **DateTime** | The timestamp when the webhook last received an error when sending an event to the target. | [optional] [readonly] 
**LastFailureContent** | **string** | The contents of the last error response sent to the webhook when attempting to deliver events to the target. | [optional] [readonly] 
**LastSuccessAt** | **DateTime** | The timestamp when the webhook last successfully sent an event to the target. | [optional] [readonly] 
**Filters** | [**List&lt;WebhookResponseAllOfFilters&gt;**](WebhookResponseAllOfFilters.md) | Whitelist of filters to apply to events from this webhook. If a webhook event passes any of the filters the event will be delivered; otherwise no event will be sent to the receiving server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

