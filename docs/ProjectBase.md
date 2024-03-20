# AsanaNet.Model.ProjectBase

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Gid** | **string** | Globally unique identifier of the resource, as a string. | [optional] [readonly] 
**ResourceType** | **string** | The base type of this resource. | [optional] [readonly] 
**Name** | **string** | Name of the project. This is generally a short sentence fragment that fits on a line in the UI for maximum readability. However, it can be longer. | [optional] 
**Archived** | **bool** | True if the project is archived, false if not. Archived projects do not show in the UI by default and may be treated differently for queries. | [optional] 
**Color** | **string** | Color of the project. | [optional] 
**CreatedAt** | **DateTime** | The time at which this resource was created. | [optional] [readonly] 
**CurrentStatus** | [**ProjectBaseAllOfCurrentStatus**](ProjectBaseAllOfCurrentStatus.md) |  | [optional] 
**CurrentStatusUpdate** | [**ProjectBaseAllOfCurrentStatusUpdate**](ProjectBaseAllOfCurrentStatusUpdate.md) |  | [optional] 
**CustomFieldSettings** | [**List&lt;CustomFieldSettingResponse&gt;**](CustomFieldSettingResponse.md) | Array of Custom Field Settings (in compact form). | [optional] [readonly] 
**DefaultView** | **string** | The default view (list, board, calendar, or timeline) of a project. | [optional] 
**DueDate** | **DateOnly** | *Deprecated: new integrations should prefer the &#x60;due_on&#x60; field.* | [optional] 
**DueOn** | **DateOnly** | The day on which this project is due. This takes a date with format YYYY-MM-DD. | [optional] 
**HtmlNotes** | **string** | [Opt In](/docs/inputoutput-options). The notes of the project with formatting as HTML. | [optional] 
**Members** | [**List&lt;UserCompact&gt;**](UserCompact.md) | Array of users who are members of this project. | [optional] [readonly] 
**ModifiedAt** | **DateTime** | The time at which this project was last modified. *Note: This does not currently reflect any changes in associations such as tasks or comments that may have been added or removed from the project.* | [optional] [readonly] 
**Notes** | **string** | Free-form textual information associated with the project (ie., its description). | [optional] 
**VarPublic** | **bool** | True if the project is public to its team. | [optional] 
**StartOn** | **DateOnly** | The day on which work for this project begins, or null if the project has no start date. This takes a date with &#x60;YYYY-MM-DD&#x60; format. *Note: &#x60;due_on&#x60; or &#x60;due_at&#x60; must be present in the request when setting or unsetting the &#x60;start_on&#x60; parameter. Additionally, &#x60;start_on&#x60; and &#x60;due_on&#x60; cannot be the same date.* | [optional] 
**DefaultAccessLevel** | **string** | The default access for users or teams who join or are added as members to the project. | [optional] 
**MinimumAccessLevelForCustomization** | **string** | The minimum access level needed for project members to modify this project&#39;s workflow and appearance. | [optional] 
**MinimumAccessLevelForSharing** | **string** | The minimum access level needed for project members to share the project and manage project memberships. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

