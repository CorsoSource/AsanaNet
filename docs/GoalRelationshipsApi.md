# AsanaNet.Api.GoalRelationshipsApi

All URIs are relative to *https://app.asana.com/api/1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddSupportingRelationship**](GoalRelationshipsApi.md#addsupportingrelationship) | **POST** /goals/{goal_gid}/addSupportingRelationship | Add a supporting goal relationship |
| [**GetGoalRelationship**](GoalRelationshipsApi.md#getgoalrelationship) | **GET** /goal_relationships/{goal_relationship_gid} | Get a goal relationship |
| [**GetGoalRelationships**](GoalRelationshipsApi.md#getgoalrelationships) | **GET** /goal_relationships | Get goal relationships |
| [**RemoveSupportingRelationship**](GoalRelationshipsApi.md#removesupportingrelationship) | **POST** /goals/{goal_gid}/removeSupportingRelationship | Removes a supporting goal relationship |
| [**UpdateGoalRelationship**](GoalRelationshipsApi.md#updategoalrelationship) | **PUT** /goal_relationships/{goal_relationship_gid} | Update a goal relationship |

<a id="addsupportingrelationship"></a>
# **AddSupportingRelationship**
> GetGoalRelationship200Response AddSupportingRelationship (string goalGid, AddSupportingRelationshipRequest addSupportingRelationshipRequest, bool? optPretty = null, List<string>? optFields = null)

Add a supporting goal relationship

Creates a goal relationship by adding a supporting resource to a given goal.  Returns the newly created goal relationship record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class AddSupportingRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoalRelationshipsApi(config);
            var goalGid = 12345;  // string | Globally unique identifier for the goal.
            var addSupportingRelationshipRequest = new AddSupportingRelationshipRequest(); // AddSupportingRelationshipRequest | The supporting resource to be added to the goal
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Add a supporting goal relationship
                GetGoalRelationship200Response result = apiInstance.AddSupportingRelationship(goalGid, addSupportingRelationshipRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalRelationshipsApi.AddSupportingRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddSupportingRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a supporting goal relationship
    ApiResponse<GetGoalRelationship200Response> response = apiInstance.AddSupportingRelationshipWithHttpInfo(goalGid, addSupportingRelationshipRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalRelationshipsApi.AddSupportingRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGid** | **string** | Globally unique identifier for the goal. |  |
| **addSupportingRelationshipRequest** | [**AddSupportingRelationshipRequest**](AddSupportingRelationshipRequest.md) | The supporting resource to be added to the goal |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetGoalRelationship200Response**](GetGoalRelationship200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully created the goal relationship. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgoalrelationship"></a>
# **GetGoalRelationship**
> GetGoalRelationship200Response GetGoalRelationship (string goalRelationshipGid, bool? optPretty = null, List<string>? optFields = null)

Get a goal relationship

Returns the complete updated goal relationship record for a single goal relationship.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetGoalRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoalRelationshipsApi(config);
            var goalRelationshipGid = 12345;  // string | Globally unique identifier for the goal relationship.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get a goal relationship
                GetGoalRelationship200Response result = apiInstance.GetGoalRelationship(goalRelationshipGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalRelationshipsApi.GetGoalRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGoalRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a goal relationship
    ApiResponse<GetGoalRelationship200Response> response = apiInstance.GetGoalRelationshipWithHttpInfo(goalRelationshipGid, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalRelationshipsApi.GetGoalRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalRelationshipGid** | **string** | Globally unique identifier for the goal relationship. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetGoalRelationship200Response**](GetGoalRelationship200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the record for the goal relationship. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgoalrelationships"></a>
# **GetGoalRelationships**
> GetGoalRelationships200Response GetGoalRelationships (string supportedGoal, bool? optPretty = null, int? limit = null, string? offset = null, string? resourceSubtype = null, List<string>? optFields = null)

Get goal relationships

Returns compact goal relationship records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetGoalRelationshipsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoalRelationshipsApi(config);
            var supportedGoal = 12345;  // string | Globally unique identifier for the supported goal in the goal relationship.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var limit = 50;  // int? | Results per page. The number of objects to return per page. The value must be between 1 and 100. (optional) 
            var offset = eyJ0eXAiOJiKV1iQLCJhbGciOiJIUzI1NiJ9;  // string? | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. 'Note: You can only pass in an offset that was returned to you via a previously paginated request.' (optional) 
            var resourceSubtype = subgoal;  // string? | If provided, filter to goal relationships with a given resource_subtype. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get goal relationships
                GetGoalRelationships200Response result = apiInstance.GetGoalRelationships(supportedGoal, optPretty, limit, offset, resourceSubtype, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalRelationshipsApi.GetGoalRelationships: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGoalRelationshipsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get goal relationships
    ApiResponse<GetGoalRelationships200Response> response = apiInstance.GetGoalRelationshipsWithHttpInfo(supportedGoal, optPretty, limit, offset, resourceSubtype, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalRelationshipsApi.GetGoalRelationshipsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **supportedGoal** | **string** | Globally unique identifier for the supported goal in the goal relationship. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **limit** | **int?** | Results per page. The number of objects to return per page. The value must be between 1 and 100. | [optional]  |
| **offset** | **string?** | Offset token. An offset to the next page returned by the API. A pagination request will return an offset token, which can be used as an input parameter to the next request. If an offset is not passed in, the API will return the first page of results. &#39;Note: You can only pass in an offset that was returned to you via a previously paginated request.&#39; | [optional]  |
| **resourceSubtype** | **string?** | If provided, filter to goal relationships with a given resource_subtype. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetGoalRelationships200Response**](GetGoalRelationships200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved the requested goal relationships. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removesupportingrelationship"></a>
# **RemoveSupportingRelationship**
> DeleteAttachment200Response RemoveSupportingRelationship (string goalGid, RemoveSupportingRelationshipRequest removeSupportingRelationshipRequest, bool? optPretty = null)

Removes a supporting goal relationship

Removes a goal relationship for a given parent goal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class RemoveSupportingRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoalRelationshipsApi(config);
            var goalGid = 12345;  // string | Globally unique identifier for the goal.
            var removeSupportingRelationshipRequest = new RemoveSupportingRelationshipRequest(); // RemoveSupportingRelationshipRequest | The supporting resource to be removed from the goal
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 

            try
            {
                // Removes a supporting goal relationship
                DeleteAttachment200Response result = apiInstance.RemoveSupportingRelationship(goalGid, removeSupportingRelationshipRequest, optPretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalRelationshipsApi.RemoveSupportingRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveSupportingRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Removes a supporting goal relationship
    ApiResponse<DeleteAttachment200Response> response = apiInstance.RemoveSupportingRelationshipWithHttpInfo(goalGid, removeSupportingRelationshipRequest, optPretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalRelationshipsApi.RemoveSupportingRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalGid** | **string** | Globally unique identifier for the goal. |  |
| **removeSupportingRelationshipRequest** | [**RemoveSupportingRelationshipRequest**](RemoveSupportingRelationshipRequest.md) | The supporting resource to be removed from the goal |  |
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
| **200** | Successfully removed the goal relationship. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updategoalrelationship"></a>
# **UpdateGoalRelationship**
> GetGoalRelationship200Response UpdateGoalRelationship (string goalRelationshipGid, UpdateGoalRelationshipRequest updateGoalRelationshipRequest, bool? optPretty = null, List<string>? optFields = null)

Update a goal relationship

An existing goal relationship can be updated by making a PUT request on the URL for that goal relationship. Only the fields provided in the `data` block will be updated; any unspecified fields will remain unchanged.  Returns the complete updated goal relationship record.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class UpdateGoalRelationshipExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GoalRelationshipsApi(config);
            var goalRelationshipGid = 12345;  // string | Globally unique identifier for the goal relationship.
            var updateGoalRelationshipRequest = new UpdateGoalRelationshipRequest(); // UpdateGoalRelationshipRequest | The updated fields for the goal relationship.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Update a goal relationship
                GetGoalRelationship200Response result = apiInstance.UpdateGoalRelationship(goalRelationshipGid, updateGoalRelationshipRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GoalRelationshipsApi.UpdateGoalRelationship: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGoalRelationshipWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a goal relationship
    ApiResponse<GetGoalRelationship200Response> response = apiInstance.UpdateGoalRelationshipWithHttpInfo(goalRelationshipGid, updateGoalRelationshipRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GoalRelationshipsApi.UpdateGoalRelationshipWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **goalRelationshipGid** | **string** | Globally unique identifier for the goal relationship. |  |
| **updateGoalRelationshipRequest** | [**UpdateGoalRelationshipRequest**](UpdateGoalRelationshipRequest.md) | The updated fields for the goal relationship. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**GetGoalRelationship200Response**](GetGoalRelationship200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated the goal relationship. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

