# AsanaNet.Model.TaskTemplateRecipe

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the task that will be created from this template. | [optional] 
**TaskResourceSubtype** | **string** | The subtype of the task that will be created from this template. | [optional] 
**Description** | **string** | Description of the task that will be created from this template. | [optional] 
**HtmlDescription** | **string** | HTML description of the task that will be created from this template. | [optional] 
**Memberships** | [**List&lt;ProjectCompact&gt;**](ProjectCompact.md) | Array of projects that the task created from this template will be added to | [optional] 
**RelativeStartOn** | **int?** | The number of days after the task has been instantiated on which that the task will start | [optional] 
**RelativeDueOn** | **int?** | The number of days after the task has been instantiated on which that the task will be due | [optional] 
**DueTime** | **string** | The time of day that the task will be due | [optional] 
**Dependencies** | [**List&lt;TaskTemplateRecipeCompact&gt;**](TaskTemplateRecipeCompact.md) | Array of task templates that the task created from this template will depend on | [optional] 
**Dependents** | [**List&lt;TaskTemplateRecipeCompact&gt;**](TaskTemplateRecipeCompact.md) | Array of task templates that will depend on the task created from this template | [optional] 
**Followers** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users that will be added as followers to the task created from this template | [optional] 
**Attachments** | [**List&lt;AttachmentCompact&gt;**](AttachmentCompact.md) | Array of attachments that will be added to the task created from this template | [optional] 
**Subtasks** | [**List&lt;TaskTemplateRecipeCompact&gt;**](TaskTemplateRecipeCompact.md) | Array of subtasks that will be added to the task created from this template | [optional] 
**CustomFields** | [**List&lt;CustomFieldCompact&gt;**](CustomFieldCompact.md) | Array of custom fields that will be added to the task created from this template | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

