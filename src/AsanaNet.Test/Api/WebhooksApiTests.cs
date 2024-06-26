/*
 * Asana
 *
 * This is the interface for interacting with the [Asana Platform](https://developers.asana.com). Our API reference is generated from our [OpenAPI spec] (https://raw.githubusercontent.com/Asana/openapi/master/defs/asana_oas.yaml).
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using AsanaNet.Client;
using AsanaNet.Api;
// uncomment below to import models
//using AsanaNet.Model;

namespace AsanaNet.Test.Api
{
    /// <summary>
    ///  Class for testing WebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhooksApiTests : IDisposable
    {
        private WebhooksApi instance;

        public WebhooksApiTests()
        {
            instance = new WebhooksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhooksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhooksApi
            //Assert.IsType<WebhooksApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhook
        /// </summary>
        [Fact]
        public void CreateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateWebhookRequest createWebhookRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateWebhook(createWebhookRequest, optPretty, optFields);
            //Assert.IsType<CreateWebhook201Response>(response);
        }

        /// <summary>
        /// Test DeleteWebhook
        /// </summary>
        [Fact]
        public void DeleteWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string webhookGid = null;
            //bool? optPretty = null;
            //var response = instance.DeleteWebhook(webhookGid, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test GetWebhook
        /// </summary>
        [Fact]
        public void GetWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string webhookGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetWebhook(webhookGid, optPretty, optFields);
            //Assert.IsType<CreateWebhook201Response>(response);
        }

        /// <summary>
        /// Test GetWebhooks
        /// </summary>
        [Fact]
        public void GetWebhooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspace = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //string? resource = null;
            //List<string>? optFields = null;
            //var response = instance.GetWebhooks(workspace, optPretty, limit, offset, resource, optFields);
            //Assert.IsType<GetWebhooks200Response>(response);
        }

        /// <summary>
        /// Test UpdateWebhook
        /// </summary>
        [Fact]
        public void UpdateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string webhookGid = null;
            //UpdateWebhookRequest updateWebhookRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.UpdateWebhook(webhookGid, updateWebhookRequest, optPretty, optFields);
            //Assert.IsType<CreateWebhook201Response>(response);
        }
    }
}
