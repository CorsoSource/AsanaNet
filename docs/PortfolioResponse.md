# AsanaNet.Model.PortfolioResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the portfolio. | [optional] 
**Color** | **string** | Color of the portfolio. | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CreatedBy** | [**UserCompact**](UserCompact.md) |  | [optional] 
**CustomFieldSettings** | [**List&lt;CustomFieldSettingResponse&gt;**](CustomFieldSettingResponse.md) | Array of custom field settings applied to the portfolio. | [optional] 
**CurrentStatusUpdate** | [**PortfolioResponseAllOfCurrentStatusUpdate**](PortfolioResponseAllOfCurrentStatusUpdate.md) |  | [optional] 
**DueOn** | **DateTime?** | The localized day on which this portfolio is due. This takes a date with format YYYY-MM-DD. | [optional] 
**CustomFields** | [**List&lt;CustomFieldCompact&gt;**](CustomFieldCompact.md) | Array of Custom Fields. | [optional] 
**Members** | [**List&lt;UserCompact&gt;**](UserCompact.md) |  | [optional] [readonly] 
**Owner** | [**UserCompact**](UserCompact.md) |  | [optional] 
**StartOn** | **DateTime?** | The day on which work for this portfolio begins, or null if the portfolio has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.* | [optional] 
**Workspace** | [**PortfolioResponseAllOfWorkspace**](PortfolioResponseAllOfWorkspace.md) |  | [optional] 
**PermalinkUrl** | **string** | A url that points directly to the object within Asana. | [optional] [readonly] 
**VarPublic** | **bool** | True if the portfolio is public to its workspace members. | [optional] 
**ProjectTemplates** | [**List&lt;ProjectTemplateCompact&gt;**](ProjectTemplateCompact.md) | Array of project templates that are in the portfolio | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

