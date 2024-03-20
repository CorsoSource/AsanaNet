# AsanaNet.Model.OrganizationExportCompact

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**DownloadUrl** | **string** | Download this URL to retreive the full export of the organization in JSON format. It will be compressed in a gzip (.gz) container.  *Note: May be null if the export is still in progress or failed.  If present, this URL may only be valid for 1 hour from the time of retrieval. You should avoid persisting this URL somewhere and rather refresh on demand to ensure you do not keep stale URLs.* | [optional] [readonly] 
**State** | **string** | The current state of the export. | [optional] [readonly] 
**Organization** | [**WorkspaceCompact**](WorkspaceCompact.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

