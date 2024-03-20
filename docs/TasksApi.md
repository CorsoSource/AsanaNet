# AsanaNet.Api.TasksApi

All URIs are relative to *https://app.asana.com/api/1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddDependenciesForTask**](TasksApi.md#adddependenciesfortask) | **POST** /tasks/{task_gid}/addDependencies | Set dependencies for a task |
| [**AddDependentsForTask**](TasksApi.md#adddependentsfortask) | **POST** /tasks/{task_gid}/addDependents | Set dependents for a task |
| [**AddFollowersForTask**](TasksApi.md#addfollowersfortask) | **POST** /tasks/{task_gid}/addFollowers | Add followers to a task |
| [**AddProjectForTask**](TasksApi.md#addprojectfortask) | **POST** /tasks/{task_gid}/addProject | Add a project to a task |
| [**AddTagForTask**](TasksApi.md#addtagfortask) | **POST** /tasks/{task_gid}/addTag | Add a tag to a task |
| [**CreateSubtaskForTask**](TasksApi.md#createsubtaskfortask) | **POST** /tasks/{task_gid}/subtasks | Create a subtask |
| [**CreateTask**](TasksApi.md#createtask) | **POST** /tasks | Create a task |
| [**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /tasks/{task_gid} | Delete a task |
| [**DuplicateTask**](TasksApi.md#duplicatetask) | **POST** /tasks/{task_gid}/duplicate | Duplicate a task |
| [**GetDependenciesForTask**](TasksApi.md#getdependenciesfortask) | **GET** /tasks/{task_gid}/dependencies | Get dependencies from a task |
| [**GetDependentsForTask**](TasksApi.md#getdependentsfortask) | **GET** /tasks/{task_gid}/dependents | Get dependents from a task |
| [**GetSubtasksForTask**](TasksApi.md#getsubtasksfortask) | **GET** /tasks/{task_gid}/subtasks | Get subtasks from a task |
| [**GetTask**](TasksApi.md#gettask) | **GET** /tasks/{task_gid} | Get a task |
| [**GetTaskForCustomID**](TasksApi.md#gettaskforcustomid) | **GET** /workspaces/{workspace_gid}/tasks/custom_id/{custom_id} | Get a task for a given custom ID |
| [**GetTasks**](TasksApi.md#gettasks) | **GET** /tasks | Get multiple tasks |
| [**GetTasksForProject**](TasksApi.md#gettasksforproject) | **GET** /projects/{project_gid}/tasks | Get tasks from a project |
| [**GetTasksForSection**](TasksApi.md#gettasksforsection) | **GET** /sections/{section_gid}/tasks | Get tasks from a section |
| [**GetTasksForTag**](TasksApi.md#gettasksfortag) | **GET** /tags/{tag_gid}/tasks | Get tasks from a tag |
| [**GetTasksForUserTaskList**](TasksApi.md#gettasksforusertasklist) | **GET** /user_task_lists/{user_task_list_gid}/tasks | Get tasks from a user task list |
| [**RemoveDependenciesForTask**](TasksApi.md#removedependenciesfortask) | **POST** /tasks/{task_gid}/removeDependencies | Unlink dependencies from a task |
| [**RemoveDependentsForTask**](TasksApi.md#removedependentsfortask) | **POST** /tasks/{task_gid}/removeDependents | Unlink dependents from a task |
| [**RemoveFollowerForTask**](TasksApi.md#removefollowerfortask) | **POST** /tasks/{task_gid}/removeFollowers | Remove followers from a task |
| [**RemoveProjectForTask**](TasksApi.md#removeprojectfortask) | **POST** /tasks/{task_gid}/removeProject | Remove a project from a task |
| [**RemoveTagForTask**](TasksApi.md#removetagfortask) | **POST** /tasks/{task_gid}/removeTag | Remove a tag from a task |
| [**SearchTasksForWorkspace**](TasksApi.md#searchtasksforworkspace) | **GET** /workspaces/{workspace_gid}/tasks/search | Search tasks in a workspace |
| [**SetParentForTask**](TasksApi.md#setparentfortask) | **POST** /tasks/{task_gid}/setParent | Set the parent of a task |
| [**UpdateTask**](TasksApi.md#updatetask) | **PUT** /tasks/{task_gid} | Update a task |

<a id="adddependenciesfortask"></a>
# **AddDependenciesForTask**
> DeleteAttachment200Response AddDependenciesForTask (string taskGid, AddDependenciesForTaskRequest addDependenciesForTaskRequest, bool? optPretty = null)

Set dependencies for a task

Marks a set of tasks as dependencies of this task, if they are not already dependencies. *A task can have at most 30 dependents and dependencies combined*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddDependenciesForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addDependenciesForTaskRequest = new AddDependenciesForTaskRequest(); // AddDependenciesForTaskRequest | The list of tasks to set as dependencies.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Set dependencies for a task
                DeleteAttachment200Response result = apiInstance.AddDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddDependenciesForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDependenciesForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set dependencies for a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.AddDependenciesForTaskWithHttpInfo(taskGid, addDependenciesForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.AddDependenciesForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addDependenciesForTaskRequest** | [**AddDependenciesForTaskRequest**](AddDependenciesForTaskRequest.md) | The list of tasks to set as dependencies. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully set the specified dependencies on the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="adddependentsfortask"></a>
# **AddDependentsForTask**
> DeleteAttachment200Response AddDependentsForTask (string taskGid, AddDependentsForTaskRequest addDependentsForTaskRequest, bool? optPretty = null)

Set dependents for a task

Marks a set of tasks as dependents of this task, if they are not already dependents. *A task can have at most 30 dependents and dependencies combined*.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddDependentsForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addDependentsForTaskRequest = new AddDependentsForTaskRequest(); // AddDependentsForTaskRequest | The list of tasks to add as dependents.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Set dependents for a task
                DeleteAttachment200Response result = apiInstance.AddDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddDependentsForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddDependentsForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set dependents for a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.AddDependentsForTaskWithHttpInfo(taskGid, addDependentsForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.AddDependentsForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addDependentsForTaskRequest** | [**AddDependentsForTaskRequest**](AddDependentsForTaskRequest.md) | The list of tasks to add as dependents. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully set the specified dependents on the given task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addfollowersfortask"></a>
# **AddFollowersForTask**
> CreateTask201Response AddFollowersForTask (string taskGid, AddFollowersRequest addFollowersRequest, bool? optPretty = null, List<string>? optFields = null)

Add followers to a task

Adds followers to a task. Returns an empty data block. Each task can be associated with zero or more followers in the system. Requests to add/remove followers, if successful, will return the complete updated task record, described above.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddFollowersForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addFollowersRequest = new AddFollowersRequest(); // AddFollowersRequest | The followers to add to the task.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Add followers to a task
                CreateTask201Response result = apiInstance.AddFollowersForTask(taskGid, addFollowersRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddFollowersForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddFollowersForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add followers to a task
    ApiResponse<CreateTask201Response> response = apiInstance.AddFollowersForTaskWithHttpInfo(taskGid, addFollowersRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.AddFollowersForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addFollowersRequest** | [**AddFollowersRequest**](AddFollowersRequest.md) | The followers to add to the task. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added the specified followers to the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addprojectfortask"></a>
# **AddProjectForTask**
> DeleteAttachment200Response AddProjectForTask (string taskGid, AddProjectForTaskRequest addProjectForTaskRequest, bool? optPretty = null)

Add a project to a task

Adds the task to the specified project, in the optional location specified. If no location arguments are given, the task will be added to the end of the project.  `addProject` can also be used to reorder a task within a project or section that already contains it.  At most one of `insert_before`, `insert_after`, or `section` should be specified. Inserting into a section in an non-order-dependent way can be done by specifying section, otherwise, to insert within a section in a particular place, specify `insert_before` or `insert_after` and a task within the section to anchor the position of this task.  Returns an empty data block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddProjectForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addProjectForTaskRequest = new AddProjectForTaskRequest(); // AddProjectForTaskRequest | The project to add the task to.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Add a project to a task
                DeleteAttachment200Response result = apiInstance.AddProjectForTask(taskGid, addProjectForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddProjectForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddProjectForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a project to a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.AddProjectForTaskWithHttpInfo(taskGid, addProjectForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.AddProjectForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addProjectForTaskRequest** | [**AddProjectForTaskRequest**](AddProjectForTaskRequest.md) | The project to add the task to. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added the specified project to the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addtagfortask"></a>
# **AddTagForTask**
> DeleteAttachment200Response AddTagForTask (string taskGid, AddTagForTaskRequest addTagForTaskRequest, bool? optPretty = null)

Add a tag to a task

Adds a tag to a task. Returns an empty data block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddTagForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addTagForTaskRequest = new AddTagForTaskRequest(); // AddTagForTaskRequest | The tag to add to the task.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Add a tag to a task
                DeleteAttachment200Response result = apiInstance.AddTagForTask(taskGid, addTagForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.AddTagForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddTagForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a tag to a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.AddTagForTaskWithHttpInfo(taskGid, addTagForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.AddTagForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addTagForTaskRequest** | [**AddTagForTaskRequest**](AddTagForTaskRequest.md) | The tag to add to the task. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully added the specified tag to the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsubtaskfortask"></a>
# **CreateSubtaskForTask**
> CreateTask201Response CreateSubtaskForTask (string taskGid, CreateTaskRequest createTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Create a subtask

Creates a new subtask and adds it to the parent task. Returns the full record for the newly created subtask.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class CreateSubtaskForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var createTaskRequest = new CreateTaskRequest(); // CreateTaskRequest | The new subtask to create.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Create a subtask
                CreateTask201Response result = apiInstance.CreateSubtaskForTask(taskGid, createTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CreateSubtaskForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubtaskForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a subtask
    ApiResponse<CreateTask201Response> response = apiInstance.CreateSubtaskForTaskWithHttpInfo(taskGid, createTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.CreateSubtaskForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **createTaskRequest** | [**CreateTaskRequest**](CreateTaskRequest.md) | The new subtask to create. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created the specified subtask. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtask"></a>
# **CreateTask**
> CreateTask201Response CreateTask (CreateTaskRequest createTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Create a task

Creating a new task is as easy as POSTing to the `/tasks` endpoint with a data block containing the fields you’d like to set on the task. Any unspecified fields will take on default values.  Every task is required to be created in a specific workspace, and this workspace cannot be changed once set. The workspace need not be set explicitly if you specify `projects` or a `parent` task instead.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var createTaskRequest = new CreateTaskRequest(); // CreateTaskRequest | The task to create.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Create a task
                CreateTask201Response result = apiInstance.CreateTask(createTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a task
    ApiResponse<CreateTask201Response> response = apiInstance.CreateTaskWithHttpInfo(createTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.CreateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaskRequest** | [**CreateTaskRequest**](CreateTaskRequest.md) | The task to create. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created a new task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetask"></a>
# **DeleteTask**
> DeleteAttachment200Response DeleteTask (string taskGid, bool? optPretty = null)

Delete a task

A specific, existing task can be deleted by making a DELETE request on the URL for that task. Deleted tasks go into the “trash” of the user making the delete request. Tasks can be recovered from the trash within a period of 30 days; afterward they are completely removed from the system.  Returns an empty data record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Delete a task
                DeleteAttachment200Response result = apiInstance.DeleteTask(taskGid, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.DeleteTaskWithHttpInfo(taskGid, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.DeleteTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully deleted the specified task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="duplicatetask"></a>
# **DuplicateTask**
> GetJob200Response DuplicateTask (string taskGid, DuplicateTaskRequest duplicateTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Duplicate a task

Creates and returns a job that will asynchronously handle the duplication.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class DuplicateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var duplicateTaskRequest = new DuplicateTaskRequest(); // DuplicateTaskRequest | Describes the duplicate's name and the fields that will be duplicated.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Duplicate a task
                GetJob200Response result = apiInstance.DuplicateTask(taskGid, duplicateTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DuplicateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DuplicateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Duplicate a task
    ApiResponse<GetJob200Response> response = apiInstance.DuplicateTaskWithHttpInfo(taskGid, duplicateTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.DuplicateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **duplicateTaskRequest** | [**DuplicateTaskRequest**](DuplicateTaskRequest.md) | Describes the duplicate&#39;s name and the fields that will be duplicated. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetJob200Response**](GetJob200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created the job to handle duplication. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdependenciesfortask"></a>
# **GetDependenciesForTask**
> GetTasks200Response GetDependenciesForTask (string taskGid, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get dependencies from a task

Returns the compact representations of all of the dependencies of a task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetDependenciesForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get dependencies from a task
                GetTasks200Response result = apiInstance.GetDependenciesForTask(taskGid, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetDependenciesForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDependenciesForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get dependencies from a task
    ApiResponse<GetTasks200Response> response = apiInstance.GetDependenciesForTaskWithHttpInfo(taskGid, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetDependenciesForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified task&#39;s dependencies. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdependentsfortask"></a>
# **GetDependentsForTask**
> GetTasks200Response GetDependentsForTask (string taskGid, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get dependents from a task

Returns the compact representations of all of the dependents of a task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetDependentsForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get dependents from a task
                GetTasks200Response result = apiInstance.GetDependentsForTask(taskGid, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetDependentsForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDependentsForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get dependents from a task
    ApiResponse<GetTasks200Response> response = apiInstance.GetDependentsForTaskWithHttpInfo(taskGid, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetDependentsForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified dependents of the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsubtasksfortask"></a>
# **GetSubtasksForTask**
> GetTasks200Response GetSubtasksForTask (string taskGid, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get subtasks from a task

Returns a compact representation of all of the subtasks of a task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetSubtasksForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get subtasks from a task
                GetTasks200Response result = apiInstance.GetSubtasksForTask(taskGid, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetSubtasksForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubtasksForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get subtasks from a task
    ApiResponse<GetTasks200Response> response = apiInstance.GetSubtasksForTaskWithHttpInfo(taskGid, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetSubtasksForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified task&#39;s subtasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettask"></a>
# **GetTask**
> CreateTask201Response GetTask (string taskGid, bool? optPretty = null, List<string>? optFields = null)

Get a task

Returns the complete task record for a single task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get a task
                CreateTask201Response result = apiInstance.GetTask(taskGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a task
    ApiResponse<CreateTask201Response> response = apiInstance.GetTaskWithHttpInfo(taskGid, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the specified task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettaskforcustomid"></a>
# **GetTaskForCustomID**
> CreateTask201Response GetTaskForCustomID (string workspaceGid, string customId)

Get a task for a given custom ID

Returns a task given a custom ID shortcode.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTaskForCustomIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var workspaceGid = 12345;  // string | Globally unique identifier for the workspace or organization.
            var customId = EX-1;  // string | Generated custom ID for a task.

            try
            {
                // Get a task for a given custom ID
                CreateTask201Response result = apiInstance.GetTaskForCustomID(workspaceGid, customId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTaskForCustomID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskForCustomIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a task for a given custom ID
    ApiResponse<CreateTask201Response> response = apiInstance.GetTaskForCustomIDWithHttpInfo(workspaceGid, customId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTaskForCustomIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceGid** | **string** | Globally unique identifier for the workspace or organization. |  |
| **customId** | **string** | Generated custom ID for a task. |  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved task for given custom ID. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettasks"></a>
# **GetTasks**
> GetTasks200Response GetTasks (bool? optPretty = null, int? limit = null, string? offset = null, string? assignee = null, string? project = null, string? section = null, string? workspace = null, DateTime? completedSince = null, DateTime? modifiedSince = null, List<string>? optFields = null)

Get multiple tasks

Returns the compact task records for some filtered set of tasks. Use one or more of the parameters provided to filter the tasks returned. You must specify a `project` or `tag` if you do not specify `assignee` and `workspace`.  For more complex task retrieval, use [workspaces/{workspace_gid}/tasks/search](/reference/searchtasksforworkspace).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var assignee = 14641;  // string? | The assignee to filter tasks on. If searching for unassigned tasks, assignee.any = null can be specified. *Note: If you specify `assignee`, you must also specify the `workspace` to filter on.* (optional) 
            var project = 321654;  // string? | The project to filter tasks on. (optional) 
            var section = 321654;  // string? | The section to filter tasks on. (optional) 
            var workspace = 321654;  // string? | The workspace to filter tasks on. *Note: If you specify `workspace`, you must also specify the `assignee` to filter on.* (optional) 
            var completedSince = 2012-02-22T02:06:58.158Z;  // DateTime? | Only return tasks that are either incomplete or that have been completed since this time. (optional) 
            var modifiedSince = 2012-02-22T02:06:58.158Z;  // DateTime? | Only return tasks that have been modified since the given time.  *Note: A task is considered “modified” if any of its properties change, or associations between it and other objects are modified (e.g.  a task being added to a project). A task is not considered modified just because another object it is associated with (e.g. a subtask) is modified. Actions that count as modifying the task include assigning, renaming, completing, and adding stories.* (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get multiple tasks
                GetTasks200Response result = apiInstance.GetTasks(optPretty, limit, offset, assignee, project, section, workspace, completedSince, modifiedSince, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get multiple tasks
    ApiResponse<GetTasks200Response> response = apiInstance.GetTasksWithHttpInfo(optPretty, limit, offset, assignee, project, section, workspace, completedSince, modifiedSince, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **assignee** | **string?** | The assignee to filter tasks on. If searching for unassigned tasks, assignee.any &#x3D; null can be specified. *Note: If you specify &#x60;assignee&#x60;, you must also specify the &#x60;workspace&#x60; to filter on.* | [optional]  |
| **project** | **string?** | The project to filter tasks on. | [optional]  |
| **section** | **string?** | The section to filter tasks on. | [optional]  |
| **workspace** | **string?** | The workspace to filter tasks on. *Note: If you specify &#x60;workspace&#x60;, you must also specify the &#x60;assignee&#x60; to filter on.* | [optional]  |
| **completedSince** | **DateTime?** | Only return tasks that are either incomplete or that have been completed since this time. | [optional]  |
| **modifiedSince** | **DateTime?** | Only return tasks that have been modified since the given time.  *Note: A task is considered “modified” if any of its properties change, or associations between it and other objects are modified (e.g.  a task being added to a project). A task is not considered modified just because another object it is associated with (e.g. a subtask) is modified. Actions that count as modifying the task include assigning, renaming, completing, and adding stories.* | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved requested tasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettasksforproject"></a>
# **GetTasksForProject**
> GetTasks200Response GetTasksForProject (string projectGid, string? completedSince = null, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get tasks from a project

Returns the compact task records for all tasks within the given project, ordered by their priority within the project. Tasks can exist in more than one project at a time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTasksForProjectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var projectGid = 1331;  // string | Globally unique identifier for the project.
            var completedSince = 2012-02-22T02:06:58.158Z;  // string? | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  (optional) 
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get tasks from a project
                GetTasks200Response result = apiInstance.GetTasksForProject(projectGid, completedSince, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksForProject: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTasksForProjectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tasks from a project
    ApiResponse<GetTasks200Response> response = apiInstance.GetTasksForProjectWithHttpInfo(projectGid, completedSince, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTasksForProjectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectGid** | **string** | Globally unique identifier for the project. |  |
| **completedSince** | **string?** | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  | [optional]  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested project&#39;s tasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettasksforsection"></a>
# **GetTasksForSection**
> GetTasks200Response GetTasksForSection (string sectionGid, bool? optPretty = null, int? limit = null, string? offset = null, string? completedSince = null, List<string>? optFields = null)

Get tasks from a section

*Board view only*: Returns the compact section records for all tasks within the given section.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTasksForSectionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var sectionGid = 321654;  // string | The globally unique identifier for the section.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var completedSince = 2012-02-22T02:06:58.158Z;  // string? | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get tasks from a section
                GetTasks200Response result = apiInstance.GetTasksForSection(sectionGid, optPretty, limit, offset, completedSince, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksForSection: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTasksForSectionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tasks from a section
    ApiResponse<GetTasks200Response> response = apiInstance.GetTasksForSectionWithHttpInfo(sectionGid, optPretty, limit, offset, completedSince, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTasksForSectionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sectionGid** | **string** | The globally unique identifier for the section. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **completedSince** | **string?** | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the section&#39;s tasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettasksfortag"></a>
# **GetTasksForTag**
> GetTasks200Response GetTasksForTag (string tagGid, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get tasks from a tag

Returns the compact task records for all tasks with the given tag. Tasks can have more than one tag at a time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTasksForTagExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var tagGid = 11235;  // string | Globally unique identifier for the tag.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get tasks from a tag
                GetTasks200Response result = apiInstance.GetTasksForTag(tagGid, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksForTag: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTasksForTagWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tasks from a tag
    ApiResponse<GetTasks200Response> response = apiInstance.GetTasksForTagWithHttpInfo(tagGid, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTasksForTagWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tagGid** | **string** | Globally unique identifier for the tag. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the tasks associated with the specified tag. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettasksforusertasklist"></a>
# **GetTasksForUserTaskList**
> GetTasks200Response GetTasksForUserTaskList (string userTaskListGid, string? completedSince = null, bool? optPretty = null, int? limit = null, string? offset = null, List<string>? optFields = null)

Get tasks from a user task list

Returns the compact list of tasks in a user’s My Tasks list. *Note: Access control is enforced for this endpoint as with all Asana API endpoints, meaning a user’s private tasks will be filtered out if the API-authenticated user does not have access to them.* *Note: Both complete and incomplete tasks are returned by default unless they are filtered out (for example, setting `completed_since=now` will return only incomplete tasks, which is the default view for “My Tasks” in Asana.)*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetTasksForUserTaskListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var userTaskListGid = 12345;  // string | Globally unique identifier for the user task list.
            var completedSince = 2012-02-22T02:06:58.158Z;  // string? | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  (optional) 
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get tasks from a user task list
                GetTasks200Response result = apiInstance.GetTasksForUserTaskList(userTaskListGid, completedSince, optPretty, limit, offset, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTasksForUserTaskList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTasksForUserTaskListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get tasks from a user task list
    ApiResponse<GetTasks200Response> response = apiInstance.GetTasksForUserTaskListWithHttpInfo(userTaskListGid, completedSince, optPretty, limit, offset, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTasksForUserTaskListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userTaskListGid** | **string** | Globally unique identifier for the user task list. |  |
| **completedSince** | **string?** | Only return tasks that are either incomplete or that have been completed since this time. Accepts a date-time string or the keyword *now*.  | [optional]  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetTasks200Response**](GetTasks200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the user task list&#39;s tasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removedependenciesfortask"></a>
# **RemoveDependenciesForTask**
> DeleteAttachment200Response RemoveDependenciesForTask (string taskGid, AddDependenciesForTaskRequest addDependenciesForTaskRequest, bool? optPretty = null)

Unlink dependencies from a task

Unlinks a set of dependencies from this task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveDependenciesForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addDependenciesForTaskRequest = new AddDependenciesForTaskRequest(); // AddDependenciesForTaskRequest | The list of tasks to unlink as dependencies.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Unlink dependencies from a task
                DeleteAttachment200Response result = apiInstance.RemoveDependenciesForTask(taskGid, addDependenciesForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveDependenciesForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDependenciesForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink dependencies from a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.RemoveDependenciesForTaskWithHttpInfo(taskGid, addDependenciesForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.RemoveDependenciesForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addDependenciesForTaskRequest** | [**AddDependenciesForTaskRequest**](AddDependenciesForTaskRequest.md) | The list of tasks to unlink as dependencies. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully unlinked the dependencies from the specified task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removedependentsfortask"></a>
# **RemoveDependentsForTask**
> DeleteAttachment200Response RemoveDependentsForTask (string taskGid, AddDependentsForTaskRequest addDependentsForTaskRequest, bool? optPretty = null)

Unlink dependents from a task

Unlinks a set of dependents from this task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveDependentsForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var addDependentsForTaskRequest = new AddDependentsForTaskRequest(); // AddDependentsForTaskRequest | The list of tasks to remove as dependents.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Unlink dependents from a task
                DeleteAttachment200Response result = apiInstance.RemoveDependentsForTask(taskGid, addDependentsForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveDependentsForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveDependentsForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unlink dependents from a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.RemoveDependentsForTaskWithHttpInfo(taskGid, addDependentsForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.RemoveDependentsForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **addDependentsForTaskRequest** | [**AddDependentsForTaskRequest**](AddDependentsForTaskRequest.md) | The list of tasks to remove as dependents. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully unlinked the specified tasks as dependents. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removefollowerfortask"></a>
# **RemoveFollowerForTask**
> CreateTask201Response RemoveFollowerForTask (string taskGid, RemoveFollowerForTaskRequest removeFollowerForTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Remove followers from a task

Removes each of the specified followers from the task if they are following. Returns the complete, updated record for the affected task.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveFollowerForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var removeFollowerForTaskRequest = new RemoveFollowerForTaskRequest(); // RemoveFollowerForTaskRequest | The followers to remove from the task.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Remove followers from a task
                CreateTask201Response result = apiInstance.RemoveFollowerForTask(taskGid, removeFollowerForTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveFollowerForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveFollowerForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove followers from a task
    ApiResponse<CreateTask201Response> response = apiInstance.RemoveFollowerForTaskWithHttpInfo(taskGid, removeFollowerForTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.RemoveFollowerForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **removeFollowerForTaskRequest** | [**RemoveFollowerForTaskRequest**](RemoveFollowerForTaskRequest.md) | The followers to remove from the task. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed the specified followers from the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeprojectfortask"></a>
# **RemoveProjectForTask**
> DeleteAttachment200Response RemoveProjectForTask (string taskGid, RemoveProjectForTaskRequest removeProjectForTaskRequest, bool? optPretty = null)

Remove a project from a task

Removes the task from the specified project. The task will still exist in the system, but it will not be in the project anymore.  Returns an empty data block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveProjectForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var removeProjectForTaskRequest = new RemoveProjectForTaskRequest(); // RemoveProjectForTaskRequest | The project to remove the task from.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Remove a project from a task
                DeleteAttachment200Response result = apiInstance.RemoveProjectForTask(taskGid, removeProjectForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveProjectForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveProjectForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a project from a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.RemoveProjectForTaskWithHttpInfo(taskGid, removeProjectForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.RemoveProjectForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **removeProjectForTaskRequest** | [**RemoveProjectForTaskRequest**](RemoveProjectForTaskRequest.md) | The project to remove the task from. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed the specified project from the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removetagfortask"></a>
# **RemoveTagForTask**
> DeleteAttachment200Response RemoveTagForTask (string taskGid, RemoveTagForTaskRequest removeTagForTaskRequest, bool? optPretty = null)

Remove a tag from a task

Removes a tag from a task. Returns an empty data block.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveTagForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var removeTagForTaskRequest = new RemoveTagForTaskRequest(); // RemoveTagForTaskRequest | The tag to remove from the task.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Remove a tag from a task
                DeleteAttachment200Response result = apiInstance.RemoveTagForTask(taskGid, removeTagForTaskRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.RemoveTagForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveTagForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a tag from a task
    ApiResponse<DeleteAttachment200Response> response = apiInstance.RemoveTagForTaskWithHttpInfo(taskGid, removeTagForTaskRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.RemoveTagForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **removeTagForTaskRequest** | [**RemoveTagForTaskRequest**](RemoveTagForTaskRequest.md) | The tag to remove from the task. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |

### Return type

[**DeleteAttachment200Response**](DeleteAttachment200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully removed the specified tag from the task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchtasksforworkspace"></a>
# **SearchTasksForWorkspace**
> SearchTasksForWorkspace200Response SearchTasksForWorkspace (string workspaceGid, bool? optPretty = null, string? text = null, string? resourceSubtype = null, string? assigneeAny = null, string? assigneeNot = null, string? portfoliosAny = null, string? projectsAny = null, string? projectsNot = null, string? projectsAll = null, string? sectionsAny = null, string? sectionsNot = null, string? sectionsAll = null, string? tagsAny = null, string? tagsNot = null, string? tagsAll = null, string? teamsAny = null, string? followersNot = null, string? createdByAny = null, string? createdByNot = null, string? assignedByAny = null, string? assignedByNot = null, string? likedByNot = null, string? commentedOnByNot = null, DateOnly? dueOnBefore = null, DateOnly? dueOnAfter = null, DateOnly? dueOn = null, DateTime? dueAtBefore = null, DateTime? dueAtAfter = null, DateOnly? startOnBefore = null, DateOnly? startOnAfter = null, DateOnly? startOn = null, DateOnly? createdOnBefore = null, DateOnly? createdOnAfter = null, DateOnly? createdOn = null, DateTime? createdAtBefore = null, DateTime? createdAtAfter = null, DateOnly? completedOnBefore = null, DateOnly? completedOnAfter = null, DateOnly? completedOn = null, DateTime? completedAtBefore = null, DateTime? completedAtAfter = null, DateOnly? modifiedOnBefore = null, DateOnly? modifiedOnAfter = null, DateOnly? modifiedOn = null, DateTime? modifiedAtBefore = null, DateTime? modifiedAtAfter = null, bool? isBlocking = null, bool? isBlocked = null, bool? hasAttachment = null, bool? completed = null, bool? isSubtask = null, string? sortBy = null, bool? sortAscending = null, List<string>? optFields = null)

Search tasks in a workspace

To mirror the functionality of the Asana web app's advanced search feature, the Asana API has a task search endpoint that allows you to build complex filters to find and retrieve the exact data you need. #### Premium access Like the Asana web product's advance search feature, this search endpoint will only be available to premium Asana users. A user is premium if any of the following is true:  - The workspace in which the search is being performed is a premium workspace - The user is a member of a premium team inside the workspace  Even if a user is only a member of a premium team inside a non-premium workspace, search will allow them to find data anywhere in the workspace, not just inside the premium team. Making a search request using credentials of a non-premium user will result in a `402 Payment Required` error. #### Pagination Search results are not stable; repeating the same query multiple times may return the data in a different order, even if the data do not change. Because of this, the traditional [pagination](https://developers.asana.com/docs/#pagination) available elsewhere in the Asana API is not available here. However, you can paginate manually by sorting the search results by their creation time and then modifying each subsequent query to exclude data you have already seen. Page sizes are limited to a maximum of 100 items, and can be specified by the `limit` query parameter. #### Eventual consistency Changes in Asana (regardless of whether they’re made though the web product or the API) are forwarded to our search infrastructure to be indexed. This process can take between 10 and 60 seconds to complete under normal operation, and longer during some production incidents. Making a change to a task that would alter its presence in a particular search query will not be reflected immediately. This is also true of the advanced search feature in the web product. #### Rate limits You may receive a `429 Too Many Requests` response if you hit any of our [rate limits](https://developers.asana.com/docs/#rate-limits). #### Custom field parameters | Parameter name | Custom field type | Accepted type | |- --|- --|- --| | custom_fields.{gid}.is_set | All | Boolean | | custom_fields.{gid}.value | Text | String | | custom_fields.{gid}.value | Number | Number | | custom_fields.{gid}.value | Enum | Enum option ID | | custom_fields.{gid}.starts_with | Text only | String | | custom_fields.{gid}.ends_with | Text only | String | | custom_fields.{gid}.contains | Text only | String | | custom_fields.{gid}.less_than | Number only | Number | | custom_fields.{gid}.greater_than | Number only | Number |   For example, if the gid of the custom field is 12345, these query parameter to find tasks where it is set would be `custom_fields.12345.is_set=true`. To match an exact value for an enum custom field, use the gid of the desired enum option and not the name of the enum option: `custom_fields.12345.value=67890`.  **Not Supported**: searching for multiple exact matches of a custom field, searching for multi-enum custom field  *Note: If you specify `projects.any` and `sections.any`, you will receive tasks for the project **and** tasks for the section. If you're looking for only tasks in a section, omit the `projects.any` from the request.*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class SearchTasksForWorkspaceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var workspaceGid = 12345;  // string | Globally unique identifier for the workspace or organization.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var text = Bug;  // string? | Performs full-text search on both task name and description (optional) 
            var resourceSubtype = "default_task";  // string? | Filters results by the task's resource_subtype (optional)  (default to milestone)
            var assigneeAny = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var assigneeNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var portfoliosAny = 12345,23456,34567;  // string? | Comma-separated list of portfolio IDs (optional) 
            var projectsAny = 12345,23456,34567;  // string? | Comma-separated list of project IDs (optional) 
            var projectsNot = 12345,23456,34567;  // string? | Comma-separated list of project IDs (optional) 
            var projectsAll = 12345,23456,34567;  // string? | Comma-separated list of project IDs (optional) 
            var sectionsAny = 12345,23456,34567;  // string? | Comma-separated list of section or column IDs (optional) 
            var sectionsNot = 12345,23456,34567;  // string? | Comma-separated list of section or column IDs (optional) 
            var sectionsAll = 12345,23456,34567;  // string? | Comma-separated list of section or column IDs (optional) 
            var tagsAny = 12345,23456,34567;  // string? | Comma-separated list of tag IDs (optional) 
            var tagsNot = 12345,23456,34567;  // string? | Comma-separated list of tag IDs (optional) 
            var tagsAll = 12345,23456,34567;  // string? | Comma-separated list of tag IDs (optional) 
            var teamsAny = 12345,23456,34567;  // string? | Comma-separated list of team IDs (optional) 
            var followersNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var createdByAny = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var createdByNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var assignedByAny = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var assignedByNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var likedByNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var commentedOnByNot = 12345,23456,34567;  // string? | Comma-separated list of user identifiers (optional) 
            var dueOnBefore = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var dueOnAfter = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var dueOn = 2019-09-15;  // DateOnly? | ISO 8601 date string or `null` (optional) 
            var dueAtBefore = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var dueAtAfter = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var startOnBefore = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var startOnAfter = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var startOn = 2019-09-15;  // DateOnly? | ISO 8601 date string or `null` (optional) 
            var createdOnBefore = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var createdOnAfter = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var createdOn = 2019-09-15;  // DateOnly? | ISO 8601 date string or `null` (optional) 
            var createdAtBefore = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var createdAtAfter = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var completedOnBefore = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var completedOnAfter = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var completedOn = 2019-09-15;  // DateOnly? | ISO 8601 date string or `null` (optional) 
            var completedAtBefore = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var completedAtAfter = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var modifiedOnBefore = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var modifiedOnAfter = 2019-09-15;  // DateOnly? | ISO 8601 date string (optional) 
            var modifiedOn = 2019-09-15;  // DateOnly? | ISO 8601 date string or `null` (optional) 
            var modifiedAtBefore = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var modifiedAtAfter = 2019-04-15T01:01:46.055Z;  // DateTime? | ISO 8601 datetime string (optional) 
            var isBlocking = false;  // bool? | Filter to incomplete tasks with dependents (optional) 
            var isBlocked = false;  // bool? | Filter to tasks with incomplete dependencies (optional) 
            var hasAttachment = false;  // bool? | Filter to tasks with attachments (optional) 
            var completed = false;  // bool? | Filter to completed tasks (optional) 
            var isSubtask = false;  // bool? | Filter to subtasks (optional) 
            var sortBy = likes;  // string? | One of `due_date`, `created_at`, `completed_at`, `likes`, or `modified_at`, defaults to `modified_at` (optional)  (default to modified_at)
            var sortAscending = true;  // bool? | Default `false` (optional)  (default to false)
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Search tasks in a workspace
                SearchTasksForWorkspace200Response result = apiInstance.SearchTasksForWorkspace(workspaceGid, optPretty, text, resourceSubtype, assigneeAny, assigneeNot, portfoliosAny, projectsAny, projectsNot, projectsAll, sectionsAny, sectionsNot, sectionsAll, tagsAny, tagsNot, tagsAll, teamsAny, followersNot, createdByAny, createdByNot, assignedByAny, assignedByNot, likedByNot, commentedOnByNot, dueOnBefore, dueOnAfter, dueOn, dueAtBefore, dueAtAfter, startOnBefore, startOnAfter, startOn, createdOnBefore, createdOnAfter, createdOn, createdAtBefore, createdAtAfter, completedOnBefore, completedOnAfter, completedOn, completedAtBefore, completedAtAfter, modifiedOnBefore, modifiedOnAfter, modifiedOn, modifiedAtBefore, modifiedAtAfter, isBlocking, isBlocked, hasAttachment, completed, isSubtask, sortBy, sortAscending, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SearchTasksForWorkspace: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchTasksForWorkspaceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search tasks in a workspace
    ApiResponse<SearchTasksForWorkspace200Response> response = apiInstance.SearchTasksForWorkspaceWithHttpInfo(workspaceGid, optPretty, text, resourceSubtype, assigneeAny, assigneeNot, portfoliosAny, projectsAny, projectsNot, projectsAll, sectionsAny, sectionsNot, sectionsAll, tagsAny, tagsNot, tagsAll, teamsAny, followersNot, createdByAny, createdByNot, assignedByAny, assignedByNot, likedByNot, commentedOnByNot, dueOnBefore, dueOnAfter, dueOn, dueAtBefore, dueAtAfter, startOnBefore, startOnAfter, startOn, createdOnBefore, createdOnAfter, createdOn, createdAtBefore, createdAtAfter, completedOnBefore, completedOnAfter, completedOn, completedAtBefore, completedAtAfter, modifiedOnBefore, modifiedOnAfter, modifiedOn, modifiedAtBefore, modifiedAtAfter, isBlocking, isBlocked, hasAttachment, completed, isSubtask, sortBy, sortAscending, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.SearchTasksForWorkspaceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **workspaceGid** | **string** | Globally unique identifier for the workspace or organization. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **text** | **string?** | Performs full-text search on both task name and description | [optional]  |
| **resourceSubtype** | **string?** | Filters results by the task&#39;s resource_subtype | [optional] [default to milestone] |
| **assigneeAny** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **assigneeNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **portfoliosAny** | **string?** | Comma-separated list of portfolio IDs | [optional]  |
| **projectsAny** | **string?** | Comma-separated list of project IDs | [optional]  |
| **projectsNot** | **string?** | Comma-separated list of project IDs | [optional]  |
| **projectsAll** | **string?** | Comma-separated list of project IDs | [optional]  |
| **sectionsAny** | **string?** | Comma-separated list of section or column IDs | [optional]  |
| **sectionsNot** | **string?** | Comma-separated list of section or column IDs | [optional]  |
| **sectionsAll** | **string?** | Comma-separated list of section or column IDs | [optional]  |
| **tagsAny** | **string?** | Comma-separated list of tag IDs | [optional]  |
| **tagsNot** | **string?** | Comma-separated list of tag IDs | [optional]  |
| **tagsAll** | **string?** | Comma-separated list of tag IDs | [optional]  |
| **teamsAny** | **string?** | Comma-separated list of team IDs | [optional]  |
| **followersNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **createdByAny** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **createdByNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **assignedByAny** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **assignedByNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **likedByNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **commentedOnByNot** | **string?** | Comma-separated list of user identifiers | [optional]  |
| **dueOnBefore** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **dueOnAfter** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **dueOn** | **DateOnly?** | ISO 8601 date string or &#x60;null&#x60; | [optional]  |
| **dueAtBefore** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **dueAtAfter** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **startOnBefore** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **startOnAfter** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **startOn** | **DateOnly?** | ISO 8601 date string or &#x60;null&#x60; | [optional]  |
| **createdOnBefore** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **createdOnAfter** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **createdOn** | **DateOnly?** | ISO 8601 date string or &#x60;null&#x60; | [optional]  |
| **createdAtBefore** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **createdAtAfter** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **completedOnBefore** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **completedOnAfter** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **completedOn** | **DateOnly?** | ISO 8601 date string or &#x60;null&#x60; | [optional]  |
| **completedAtBefore** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **completedAtAfter** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **modifiedOnBefore** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **modifiedOnAfter** | **DateOnly?** | ISO 8601 date string | [optional]  |
| **modifiedOn** | **DateOnly?** | ISO 8601 date string or &#x60;null&#x60; | [optional]  |
| **modifiedAtBefore** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **modifiedAtAfter** | **DateTime?** | ISO 8601 datetime string | [optional]  |
| **isBlocking** | **bool?** | Filter to incomplete tasks with dependents | [optional]  |
| **isBlocked** | **bool?** | Filter to tasks with incomplete dependencies | [optional]  |
| **hasAttachment** | **bool?** | Filter to tasks with attachments | [optional]  |
| **completed** | **bool?** | Filter to completed tasks | [optional]  |
| **isSubtask** | **bool?** | Filter to subtasks | [optional]  |
| **sortBy** | **string?** | One of &#x60;due_date&#x60;, &#x60;created_at&#x60;, &#x60;completed_at&#x60;, &#x60;likes&#x60;, or &#x60;modified_at&#x60;, defaults to &#x60;modified_at&#x60; | [optional] [default to modified_at] |
| **sortAscending** | **bool?** | Default &#x60;false&#x60; | [optional] [default to false] |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**SearchTasksForWorkspace200Response**](SearchTasksForWorkspace200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the section&#39;s tasks. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setparentfortask"></a>
# **SetParentForTask**
> CreateTask201Response SetParentForTask (string taskGid, SetParentForTaskRequest setParentForTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Set the parent of a task

parent, or no parent task at all. Returns an empty data block. When using `insert_before` and `insert_after`, at most one of those two options can be specified, and they must already be subtasks of the parent.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class SetParentForTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var setParentForTaskRequest = new SetParentForTaskRequest(); // SetParentForTaskRequest | The new parent of the subtask.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Set the parent of a task
                CreateTask201Response result = apiInstance.SetParentForTask(taskGid, setParentForTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.SetParentForTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetParentForTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the parent of a task
    ApiResponse<CreateTask201Response> response = apiInstance.SetParentForTaskWithHttpInfo(taskGid, setParentForTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.SetParentForTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **setParentForTaskRequest** | [**SetParentForTaskRequest**](SetParentForTaskRequest.md) | The new parent of the subtask. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully changed the parent of the specified subtask. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetask"></a>
# **UpdateTask**
> CreateTask201Response UpdateTask (string taskGid, CreateTaskRequest createTaskRequest, bool? optPretty = null, List<string>? optFields = null)

Update a task

A specific, existing task can be updated by making a PUT request on the URL for that task. Only the fields provided in the `data` block will be updated; any unspecified fields will remain unchanged.  When using this method, it is best to specify only those fields you wish to change, or else you may overwrite changes made by another user since you last retrieved the task.  Returns the complete updated task record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var taskGid = 321654;  // string | The task to operate on.
            var createTaskRequest = new CreateTaskRequest(); // CreateTaskRequest | The task to update.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Update a task
                CreateTask201Response result = apiInstance.UpdateTask(taskGid, createTaskRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a task
    ApiResponse<CreateTask201Response> response = apiInstance.UpdateTaskWithHttpInfo(taskGid, createTaskRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.UpdateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **taskGid** | **string** | The task to operate on. |  |
| **createTaskRequest** | [**CreateTaskRequest**](CreateTaskRequest.md) | The task to update. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateTask201Response**](CreateTask201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the specified task. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

