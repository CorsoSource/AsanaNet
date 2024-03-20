# AsanaNet.Model.ProjectTemplateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the project template. | [optional] 
**Description** | **string** | Free-form textual information associated with the project template | [optional] 
**HtmlDescription** | **string** | The description of the project template with formatting as HTML. | [optional] 
**VarPublic** | **bool** | True if the project template is public to its team. | [optional] 
**Owner** | [**ProjectTemplateBaseAllOfOwner**](ProjectTemplateBaseAllOfOwner.md) |  | [optional] 
**Team** | [**TeamCompact**](TeamCompact.md) |  | [optional] 
**RequestedDates** | [**List&lt;DateVariableCompact&gt;**](DateVariableCompact.md) | Array of date variables in this project template. Calendar dates must be provided for these variables when instantiating a project. | [optional] [readonly] 
**Color** | **string** | Color of the project template. | [optional] 
**RequestedRoles** | [**List&lt;TemplateRole&gt;**](TemplateRole.md) | Array of template roles in this project template. User Ids can be provided for these variables when instantiating a project to assign template tasks to the user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

