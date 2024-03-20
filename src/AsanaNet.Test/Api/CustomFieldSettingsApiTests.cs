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
    ///  Class for testing CustomFieldSettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomFieldSettingsApiTests : IDisposable
    {
        private CustomFieldSettingsApi instance;

        public CustomFieldSettingsApiTests()
        {
            instance = new CustomFieldSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomFieldSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomFieldSettingsApi
            //Assert.IsType<CustomFieldSettingsApi>(instance);
        }

        /// <summary>
        /// Test GetCustomFieldSettingsForPortfolio
        /// </summary>
        [Fact]
        public void GetCustomFieldSettingsForPortfolioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string portfolioGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetCustomFieldSettingsForPortfolio(portfolioGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetCustomFieldSettingsForProject200Response>(response);
        }

        /// <summary>
        /// Test GetCustomFieldSettingsForProject
        /// </summary>
        [Fact]
        public void GetCustomFieldSettingsForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetCustomFieldSettingsForProject(projectGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetCustomFieldSettingsForProject200Response>(response);
        }
    }
}