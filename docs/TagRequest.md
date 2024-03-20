# AsanaNet.Model.TagRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the tag. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer. | [optional] 
**Color** | **string** | Color of the tag. | [optional] 
**Notes** | **string** | Free-form textual information associated with the tag (i.e. its description). | [optional] 
**Followers** | **List&lt;string&gt;** | An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user. | [optional] 
**Workspace** | **string** | Gid of an object. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

