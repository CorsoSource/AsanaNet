# AsanaNet.Api.OrganizationExportsApi

All URIs are relative to *https://app.asana.com/api/1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrganizationExport**](OrganizationExportsApi.md#createorganizationexport) | **POST** /organization_exports | Create an organization export request |
| [**GetOrganizationExport**](OrganizationExportsApi.md#getorganizationexport) | **GET** /organization_exports/{organization_export_gid} | Get details on an org export request |

<a id="createorganizationexport"></a>
# **CreateOrganizationExport**
> CreateOrganizationExport201Response CreateOrganizationExport (CreateOrganizationExportRequest createOrganizationExportRequest, bool? optPretty = null, List<string>? optFields = null)

Create an organization export request

This method creates a request to export an Organization. Asana will complete the export at some point after you create the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class CreateOrganizationExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationExportsApi(config);
            var createOrganizationExportRequest = new CreateOrganizationExportRequest(); // CreateOrganizationExportRequest | The organization to export.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Create an organization export request
                CreateOrganizationExport201Response result = apiInstance.CreateOrganizationExport(createOrganizationExportRequest, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationExportsApi.CreateOrganizationExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrganizationExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an organization export request
    ApiResponse<CreateOrganizationExport201Response> response = apiInstance.CreateOrganizationExportWithHttpInfo(createOrganizationExportRequest, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationExportsApi.CreateOrganizationExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrganizationExportRequest** | [**CreateOrganizationExportRequest**](CreateOrganizationExportRequest.md) | The organization to export. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateOrganizationExport201Response**](CreateOrganizationExport201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully created organization export request. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationexport"></a>
# **GetOrganizationExport**
> CreateOrganizationExport201Response GetOrganizationExport (string organizationExportGid, bool? optPretty = null, List<string>? optFields = null)

Get details on an org export request

Returns details of a previously-requested Organization export.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class GetOrganizationExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OrganizationExportsApi(config);
            var organizationExportGid = 12345;  // string | Globally unique identifier for the organization export.
            var optPretty = true;  // bool? | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional) 
            var optFields = new List<string>?(); // List<string>? | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional) 

            try
            {
                // Get details on an org export request
                CreateOrganizationExport201Response result = apiInstance.GetOrganizationExport(organizationExportGid, optPretty, optFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationExportsApi.GetOrganizationExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get details on an org export request
    ApiResponse<CreateOrganizationExport201Response> response = apiInstance.GetOrganizationExportWithHttpInfo(organizationExportGid, optPretty, optFields);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationExportsApi.GetOrganizationExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **organizationExportGid** | **string** | Globally unique identifier for the organization export. |  |
| **optPretty** | **bool?** | Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. | [optional]  |
| **optFields** | [**List&lt;string&gt;?**](string.md) | This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. | [optional]  |

### Return type

[**CreateOrganizationExport201Response**](CreateOrganizationExport201Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved organization export object. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

