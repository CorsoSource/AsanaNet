# AsanaNet.Model.AuditLogEventActor
The entity that triggered the event. Will typically be a user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActorType** | **string** | The type of actor. Can be one of &#x60;user&#x60;, &#x60;asana&#x60;, &#x60;asana_support&#x60;, &#x60;anonymous&#x60;, or &#x60;external_administrator&#x60;. | [optional] 
**Gid** | **string** | Globally unique identifier of the actor, if it is a user. | [optional] 
**Name** | **string** | The name of the actor, if it is a user. | [optional] 
**Email** | **string** | The email of the actor, if it is a user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

