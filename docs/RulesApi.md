# AsanaNet.Api.RulesApi

All URIs are relative to *https://app.asana.com/api/1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TriggerRule**](RulesApi.md#triggerrule) | **POST** /rule_triggers/{rule_trigger_gid}/run | Trigger a rule |

<a id="triggerrule"></a>
# **TriggerRule**
> TriggerRule200Response TriggerRule (string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest)

Trigger a rule

Trigger a rule which uses an [\"incoming web request\"](/docs/incoming-web-requests) trigger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AsanaNet.Api;
using AsanaNet.Client;
using AsanaNet.Model;

namespace Example
{
    public class TriggerRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://app.asana.com/api/1.0";
            // Configure Bearer token for authorization: personalAccessToken
            config.AccessToken = "YOUR_BEARER_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RulesApi(config);
            var ruleTriggerGid = 12345;  // string | The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.
            var triggerRuleRequest = new TriggerRuleRequest(); // TriggerRuleRequest | A dictionary of variables accessible from within the rule.

            try
            {
                // Trigger a rule
                TriggerRule200Response result = apiInstance.TriggerRule(ruleTriggerGid, triggerRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulesApi.TriggerRule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TriggerRuleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trigger a rule
    ApiResponse<TriggerRule200Response> response = apiInstance.TriggerRuleWithHttpInfo(ruleTriggerGid, triggerRuleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulesApi.TriggerRuleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleTriggerGid** | **string** | The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint. |  |
| **triggerRuleRequest** | [**TriggerRuleRequest**](TriggerRuleRequest.md) | A dictionary of variables accessible from within the rule. |  |

### Return type

[**TriggerRule200Response**](TriggerRule200Response.md)

### Authorization

[personalAccessToken](../README.md#personalAccessToken), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully triggered a rule. |  -  |
| **400** | This usually occurs because of a missing or malformed parameter. Check the documentation and the syntax of your request and try again. |  -  |
| **401** | A valid authentication token was not provided with the request, so the API could not associate a user with the request. |  -  |
| **402** | The request was valid, but the queried object or object mutation specified in the request is above your current premium level. |  -  |
| **403** | The authentication and request syntax was valid but the server is refusing to complete the request. This can happen if you try to read or write to objects or properties that the user does not have access to. |  -  |
| **404** | Either the request method and path supplied do not specify a known action in the API, or the object specified by the request does not exist. |  -  |
| **500** | There was a problem on Asana’s end. In the event of a server error the response body should contain an error phrase. These phrases can be used by Asana support to quickly look up the incident that caused the server error. Some errors are due to server load, and will not supply an error phrase. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

