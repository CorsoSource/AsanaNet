# AsanaNet.Model.PortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the portfolio. | [optional] 
**Color** | **string** | Color of the portfolio. | [optional] 
**Members** | **List&lt;string&gt;** | An array of strings identifying users. These can either be the string \&quot;me\&quot;, an email, or the gid of a user. | [optional] [readonly] 
**Workspace** | **string** | Gid of an object. | [optional] 
**VarPublic** | **bool** | True if the portfolio is public to its workspace members. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

