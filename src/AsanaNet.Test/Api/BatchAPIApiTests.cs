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
    ///  Class for testing BatchAPIApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BatchAPIApiTests : IDisposable
    {
        private BatchAPIApi instance;

        public BatchAPIApiTests()
        {
            instance = new BatchAPIApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BatchAPIApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BatchAPIApi
            //Assert.IsType<BatchAPIApi>(instance);
        }

        /// <summary>
        /// Test CreateBatchRequest
        /// </summary>
        [Fact]
        public void CreateBatchRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBatchRequestRequest createBatchRequestRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateBatchRequest(createBatchRequestRequest, optPretty, optFields);
            //Assert.IsType<CreateBatchRequest200Response>(response);
        }
    }
}