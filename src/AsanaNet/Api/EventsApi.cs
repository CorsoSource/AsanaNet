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
    public interface IEventsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get events on a resource
        /// </summary>
        /// <remarks>
        /// Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetEvents200Response</returns>
        GetEvents200Response GetEvents(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0);

        /// <summary>
        /// Get events on a resource
        /// </summary>
        /// <remarks>
        /// Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetEvents200Response</returns>
        ApiResponse<GetEvents200Response> GetEventsWithHttpInfo(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get events on a resource
        /// </summary>
        /// <remarks>
        /// Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetEvents200Response</returns>
        System.Threading.Tasks.Task<GetEvents200Response> GetEventsAsync(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get events on a resource
        /// </summary>
        /// <remarks>
        /// Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </remarks>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetEvents200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetEvents200Response>> GetEventsWithHttpInfoAsync(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEventsApi : IEventsApiSync, IEventsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EventsApi : IEventsApi
    {
        private AsanaNet.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EventsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EventsApi(AsanaNet.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="EventsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public EventsApi(AsanaNet.Client.ISynchronousClient client, AsanaNet.Client.IAsynchronousClient asyncClient, AsanaNet.Client.IReadableConfiguration configuration)
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
        /// Get events on a resource Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>GetEvents200Response</returns>
        public GetEvents200Response GetEvents(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0)
        {
            AsanaNet.Client.ApiResponse<GetEvents200Response> localVarResponse = GetEventsWithHttpInfo(resource, sync, optPretty, optFields);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get events on a resource Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of GetEvents200Response</returns>
        public AsanaNet.Client.ApiResponse<GetEvents200Response> GetEventsWithHttpInfo(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0)
        {
            // verify the required parameter 'resource' is set
            if (resource == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'resource' when calling EventsApi->GetEvents");
            }

            AsanaNet.Client.RequestOptions localVarRequestOptions = new AsanaNet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "resource", resource));
            if (sync != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "sync", sync));
            }
            if (optPretty != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "opt_pretty", optPretty));
            }
            if (optFields != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("csv", "opt_fields", optFields));
            }

            localVarRequestOptions.Operation = "EventsApi.GetEvents";
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
            var localVarResponse = this.Client.Get<GetEvents200Response>("/events", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get events on a resource Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GetEvents200Response</returns>
        public async System.Threading.Tasks.Task<GetEvents200Response> GetEventsAsync(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            AsanaNet.Client.ApiResponse<GetEvents200Response> localVarResponse = await GetEventsWithHttpInfoAsync(resource, sync, optPretty, optFields, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get events on a resource Returns the full record for all events that have occurred since the sync token was created.  A &#x60;GET&#x60; request to the endpoint &#x60;/[path_to_resource]/events&#x60; can be made in lieu of including the resource ID in the data for the request.  Asana limits a single sync token to 100 events. If more than 100 events exist for a given resource, &#x60;has_more: true&#x60; will be returned in the response, indicating that there are more events to pull.  *Note: The resource returned will be the resource that triggered the event. This may be different from the one that the events were requested for. For example, a subscription to a project will contain events for tasks contained within the project.*
        /// </summary>
        /// <exception cref="AsanaNet.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resource">A resource ID to subscribe to. The resource can be a task, project, or goal.</param>
        /// <param name="sync">A sync token received from the last request, or none on first sync. Events will be returned from the point in time that the sync token was generated. *Note: On your first request, omit the sync token. The response will be the same as for an expired sync token, and will include a new valid sync token.If the sync token is too old (which may happen from time to time) the API will return a &#x60;412 Precondition Failed&#x60; error, and include a fresh sync token in the response.* (optional)</param>
        /// <param name="optPretty">Provides “pretty” output. Provides the response in a “pretty” format. In the case of JSON this means doing proper line breaking and indentation to make it readable. This will take extra time and increase the response size so it is advisable only to use this during debugging. (optional)</param>
        /// <param name="optFields">This endpoint returns a compact resource, which excludes some properties by default. To include those optional properties, set this query parameter to a comma-separated list of the properties you wish to include. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GetEvents200Response)</returns>
        public async System.Threading.Tasks.Task<AsanaNet.Client.ApiResponse<GetEvents200Response>> GetEventsWithHttpInfoAsync(string resource, string? sync = default(string?), bool? optPretty = default(bool?), List<string>? optFields = default(List<string>?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'resource' is set
            if (resource == null)
            {
                throw new AsanaNet.Client.ApiException(400, "Missing required parameter 'resource' when calling EventsApi->GetEvents");
            }


            AsanaNet.Client.RequestOptions localVarRequestOptions = new AsanaNet.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "resource", resource));
            if (sync != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "sync", sync));
            }
            if (optPretty != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("", "opt_pretty", optPretty));
            }
            if (optFields != null)
            {
                localVarRequestOptions.QueryParameters.Add(AsanaNet.Client.ClientUtils.ParameterToMultiMap("csv", "opt_fields", optFields));
            }

            localVarRequestOptions.Operation = "EventsApi.GetEvents";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<GetEvents200Response>("/events", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetEvents", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
