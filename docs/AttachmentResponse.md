# AsanaNet.Model.AttachmentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the file. | [optional] [readonly] 
**ResourceSubtype** | **string** | The service hosting the attachment. Valid values are &#x60;asana&#x60;, &#x60;dropbox&#x60;, &#x60;gdrive&#x60;, &#x60;onedrive&#x60;, &#x60;box&#x60;, &#x60;vimeo&#x60;, and &#x60;external&#x60;. | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**DownloadUrl** | **string** | The URL containing the content of the attachment. *Note:* May be null if the attachment is hosted by [Box](https://www.box.com/) and will be null if the attachment is a Video Message hosted by [Vimeo](https://vimeo.com/). If present, this URL may only be valid for two minutes from the time of retrieval. You should avoid persisting this URL somewhere and just refresh it on demand to ensure you do not keep stale URLs. | [optional] [readonly] 
**PermanentUrl** | **string** |  | [optional] [readonly] 
**Host** | **string** | The service hosting the attachment. Valid values are &#x60;asana&#x60;, &#x60;dropbox&#x60;, &#x60;gdrive&#x60;, &#x60;box&#x60;, and &#x60;vimeo&#x60;. | [optional] [readonly] 
**Parent** | [**AttachmentResponseAllOfParent**](AttachmentResponseAllOfParent.md) |  | [optional] 
**Size** | **int** | The size of the attachment in bytes. Only present when the &#x60;resource_subtype&#x60; is &#x60;asana&#x60;. | [optional] [readonly] 
**ViewUrl** | **string** | The URL where the attachment can be viewed, which may be friendlier to users in a browser than just directing them to a raw file. May be null if no view URL exists for the service. | [optional] [readonly] 
**ConnectedToApp** | **bool** | Whether the attachment is connected to the app making the request for the purposes of showing an app components widget. Only present when the &#x60;resource_subtype&#x60; is &#x60;external&#x60; or &#x60;gdrive&#x60;. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

