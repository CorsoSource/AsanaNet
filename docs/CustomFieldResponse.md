# AsanaNet.Model.CustomFieldResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the custom field. | [optional] 
**ResourceSubtype** | **string** | The type of the custom field. Must be one of the given values.  | [optional] [readonly] 
**Type** | **string** | *Deprecated: new integrations should prefer the resource_subtype field.* The type of the custom field. Must be one of the given values.  | [optional] [readonly] 
**EnumOptions** | [**List&lt;EnumOption&gt;**](EnumOption.md) | *Conditional*. Only relevant for custom fields of type &#x60;enum&#x60;. This array specifies the possible values which an &#x60;enum&#x60; custom field can adopt. To modify the enum options, refer to [working with enum options](/reference/createenumoptionforcustomfield). | [optional] 
**Enabled** | **bool** | *Conditional*. Determines if the custom field is enabled or not. | [optional] [readonly] 
**RepresentationType** | **string** | This field tells the type of the custom field. | [optional] [readonly] 
**IdPrefix** | **string** | This field is the unique custom ID string for the custom field. | [optional] 
**IsFormulaField** | **bool** | *Conditional*. This flag describes whether a custom field is a formula custom field. | [optional] 
**DateValue** | [**CustomFieldCompactAllOfDateValue**](CustomFieldCompactAllOfDateValue.md) |  | [optional] 
**EnumValue** | [**CustomFieldCompactAllOfEnumValue**](CustomFieldCompactAllOfEnumValue.md) |  | [optional] 
**MultiEnumValues** | [**List&lt;EnumOption&gt;**](EnumOption.md) | *Conditional*. Only relevant for custom fields of type &#x60;multi_enum&#x60;. This object is the chosen values of a &#x60;multi_enum&#x60; custom field. | [optional] 
**NumberValue** | **decimal?** | *Conditional*. This number is the value of a &#x60;number&#x60; custom field. | [optional] 
**TextValue** | **string** | *Conditional*. This string is the value of a &#x60;text&#x60; custom field. | [optional] 
**DisplayValue** | **string** | A string representation for the value of the custom field. Integrations that don&#39;t require the underlying type should use this field to read values. Using this field will future-proof an app against new custom field types. | [optional] [readonly] 
**Description** | **string** | [Opt In](/docs/inputoutput-options). The description of the custom field. | [optional] 
**Precision** | **int** | Only relevant for custom fields of type ‘Number’. This field dictates the number of places after the decimal to round to, i.e. 0 is integer values, 1 rounds to the nearest tenth, and so on. Must be between 0 and 6, inclusive. For percentage format, this may be unintuitive, as a value of 0.25 has a precision of 0, while a value of 0.251 has a precision of 1. This is due to 0.25 being displayed as 25%. The identifier format will always have a precision of 0. | [optional] 
**Format** | **string** | The format of this custom field. | [optional] 
**CurrencyCode** | **string** | ISO 4217 currency code to format this custom field. This will be null if the &#x60;format&#x60; is not &#x60;currency&#x60;. | [optional] 
**CustomLabel** | **string** | This is the string that appears next to the custom field value. This will be null if the &#x60;format&#x60; is not &#x60;custom&#x60;. | [optional] 
**CustomLabelPosition** | **string** | Only relevant for custom fields with &#x60;custom&#x60; format. This depicts where to place the custom label. This will be null if the &#x60;format&#x60; is not &#x60;custom&#x60;. | [optional] 
**IsGlobalToWorkspace** | **bool** | This flag describes whether this custom field is available to every container in the workspace. Before project-specific custom fields, this field was always true. | [optional] [readonly] 
**HasNotificationsEnabled** | **bool** | *Conditional*. This flag describes whether a follower of a task with this field should receive inbox notifications from changes to this field. | [optional] 
**AsanaCreatedField** | **string** | *Conditional*. A unique identifier to associate this field with the template source of truth. | [optional] [readonly] 
**IsValueReadOnly** | **bool** | *Conditional*. This flag describes whether a custom field is read only. | [optional] 
**CreatedBy** | [**CustomFieldResponseAllOfCreatedBy**](CustomFieldResponseAllOfCreatedBy.md) |  | [optional] 
**PeopleValue** | [**List&lt;UserCompact&gt;**](UserCompact.md) | *Conditional*. Only relevant for custom fields of type &#x60;people&#x60;. This array of [compact user](/reference/users) objects reflects the values of a &#x60;people&#x60; custom field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

