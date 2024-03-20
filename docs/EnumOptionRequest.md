# AsanaNet.Model.EnumOptionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | The name of the enum option. | [optional] 
**Enabled** | **bool** | Whether or not the enum option is a selectable value for the custom field. | [optional] 
**Color** | **string** | The color of the enum option. Defaults to ‘none’. | [optional] 
**InsertBefore** | **string** | An existing enum option within this custom field before which the new enum option should be inserted. Cannot be provided together with after_enum_option. | [optional] 
**InsertAfter** | **string** | An existing enum option within this custom field after which the new enum option should be inserted. Cannot be provided together with before_enum_option. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

