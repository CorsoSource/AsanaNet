# AsanaNet.Model.AuditLogEvent
An object representing a single event within an Asana domain.  Every audit log event is comprised of an `event_type`, `actor`, `resource`, and `context`. Some events will include additional metadata about the event under `details`. See our [currently supported list of events](/docs/audit-log-events#supported-audit-log-events) for more details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the &#x60;AuditLogEvent&#x60;, as a string. | [optional] 
**CreatedAt** | **DateTime** | The time the event was created. | [optional] 
**EventType** | **string** | The type of the event. | [optional] 
**EventCategory** | **string** | The category that this &#x60;event_type&#x60; belongs to. | [optional] 
**Actor** | [**AuditLogEventActor**](AuditLogEventActor.md) |  | [optional] 
**Resource** | [**AuditLogEventResource**](AuditLogEventResource.md) |  | [optional] 
**Details** | **Object** | Event specific details. The schema will vary depending on the &#x60;event_type&#x60;. | [optional] 
**Context** | [**AuditLogEventContext**](AuditLogEventContext.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

