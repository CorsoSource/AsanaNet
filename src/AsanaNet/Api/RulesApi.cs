/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/openapi/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AsanaNet.Client;
using AsanaNet.Client.Auth;
using AsanaNet.Model;

namespace AsanaNet.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRulesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Trigger a rule
        /// </summary>
        /// <remarks>
        /// Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TriggerRule200Response</returns>
        TriggerRule200Response TriggerRule(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0);

        /// <summary>
        /// Trigger a rule
        /// </summary>
        /// <remarks>
        /// Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TriggerRule200Response</returns>
        ApiResponse<TriggerRule200Response> TriggerRuleWithHttpInfo(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRulesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Trigger a rule
        /// </summary>
        /// <remarks>
        /// Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TriggerRule200Response</returns>
        System.Threading.Tasks.Task<TriggerRule200Response> TriggerRuleAsync(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Trigger a rule
        /// </summary>
        /// <remarks>
        /// Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TriggerRule200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<TriggerRule200Response>> TriggerRuleWithHttpInfoAsync(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRulesApi : IRulesApiSync, IRulesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RulesApi : IRulesApi
    {
        private AsanaNet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RulesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RulesApi(string basePath)
        {
            this.Configuration = AsanaNet.Client.Configuration.MergeConfigurations(
                AsanaNet.Client.GlobalConfiguration.Instance,
                new AsanaNet.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AsanaNet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AsanaNet.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AsanaNet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RulesApi(AsanaNet.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AsanaNet.Client.Configuration.MergeConfigurations(
                AsanaNet.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AsanaNet.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AsanaNet.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AsanaNet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public RulesApi(AsanaNet.Client.ISynchronousClient client, AsanaNet.Client.IAsynchronousClient asyncClient, AsanaNet.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AsanaNet.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AsanaNet.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AsanaNet.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AsanaNet.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AsanaNet.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Trigger a rule Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TriggerRule200Response</returns>
        public TriggerRule200Response TriggerRule(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0)
        {
            AsanaNet.Client.ApiResponse<TriggerRule200Response> localVarResponse = TriggerRuleWithHttpInfo(ruleTriggerGid, triggerRuleRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Trigger a rule Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TriggerRule200Response</returns>
        public AsanaNet.Client.ApiResponse<TriggerRule200Response> TriggerRuleWithHttpInfo(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0)
        {
            // verify the required parameter 'ruleTriggerGid' is set
            if (ruleTriggerGid == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'ruleTriggerGid' when calling RulesApi->TriggerRule");
            }

            // verify the required parameter 'triggerRuleRequest' is set
            if (triggerRuleRequest == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'triggerRuleRequest' when calling RulesApi->TriggerRule");
            }

            AsanaNet.Client.RequestOptions localVarRequestOptions = new AsanaNet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AsanaNet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AsanaNet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("rule_trigger_gid", AsanaNet.Client.ClientUtils.ParameterToString(ruleTriggerGid)); // path parameter
            localVarRequestOptions.Data = triggerRuleRequest;

            localVarRequestOptions.Operation = "RulesApi.TriggerRule";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (personalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<TriggerRule200Response>("/rule_triggers/{rule_trigger_gid}/run", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TriggerRule", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Trigger a rule Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TriggerRule200Response</returns>
        public async System.Threading.Tasks.Task<TriggerRule200Response> TriggerRuleAsync(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AsanaNet.Client.ApiResponse<TriggerRule200Response> localVarResponse = await TriggerRuleWithHttpInfoAsync(ruleTriggerGid, triggerRuleRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Trigger a rule Trigger a rule which uses an [\&quot;incoming web request\&quot;](/docs/incoming-web-requests) trigger.
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ruleTriggerGid">The ID of the incoming web request trigger. This value is a path parameter that is automatically generated for the API endpoint.</param>
        /// <param name="triggerRuleRequest">A dictionary of variables accessible from within the rule.</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TriggerRule200Response)</returns>
        public async System.Threading.Tasks.Task<AsanaNet.Client.ApiResponse<TriggerRule200Response>> TriggerRuleWithHttpInfoAsync(string ruleTriggerGid, TriggerRuleRequest triggerRuleRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'ruleTriggerGid' is set
            if (ruleTriggerGid == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'ruleTriggerGid' when calling RulesApi->TriggerRule");
            }

            // verify the required parameter 'triggerRuleRequest' is set
            if (triggerRuleRequest == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'triggerRuleRequest' when calling RulesApi->TriggerRule");
            }


            AsanaNet.Client.RequestOptions localVarRequestOptions = new AsanaNet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AsanaNet.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AsanaNet.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("rule_trigger_gid", AsanaNet.Client.ClientUtils.ParameterToString(ruleTriggerGid)); // path parameter
            localVarRequestOptions.Data = triggerRuleRequest;

            localVarRequestOptions.Operation = "RulesApi.TriggerRule";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (personalAccessToken) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }
            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<TriggerRule200Response>("/rule_triggers/{rule_trigger_gid}/run", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("TriggerRule", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}