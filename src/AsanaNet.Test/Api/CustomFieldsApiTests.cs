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
    ///  Class for testing CustomFieldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CustomFieldsApiTests : IDisposable
    {
        private CustomFieldsApi instance;

        public CustomFieldsApiTests()
        {
            instance = new CustomFieldsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CustomFieldsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CustomFieldsApi
            //Assert.IsType<CustomFieldsApi>(instance);
        }

        /// <summary>
        /// Test CreateCustomField
        /// </summary>
        [Fact]
        public void CreateCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateCustomFieldRequest createCustomFieldRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateCustomField(createCustomFieldRequest, optPretty, optFields);
            //Assert.IsType<CreateCustomField201Response>(response);
        }

        /// <summary>
        /// Test CreateEnumOptionForCustomField
        /// </summary>
        [Fact]
        public void CreateEnumOptionForCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customFieldGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //CreateEnumOptionForCustomFieldRequest? createEnumOptionForCustomFieldRequest = null;
            //var response = instance.CreateEnumOptionForCustomField(customFieldGid, optPretty, optFields, createEnumOptionForCustomFieldRequest);
            //Assert.IsType<CreateEnumOptionForCustomField201Response>(response);
        }

        /// <summary>
        /// Test DeleteCustomField
        /// </summary>
        [Fact]
        public void DeleteCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customFieldGid = null;
            //bool? optPretty = null;
            //var response = instance.DeleteCustomField(customFieldGid, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test GetCustomField
        /// </summary>
        [Fact]
        public void GetCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customFieldGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetCustomField(customFieldGid, optPretty, optFields);
            //Assert.IsType<CreateCustomField201Response>(response);
        }

        /// <summary>
        /// Test GetCustomFieldsForWorkspace
        /// </summary>
        [Fact]
        public void GetCustomFieldsForWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string workspaceGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetCustomFieldsForWorkspace(workspaceGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetCustomFieldsForWorkspace200Response>(response);
        }

        /// <summary>
        /// Test InsertEnumOptionForCustomField
        /// </summary>
        [Fact]
        public void InsertEnumOptionForCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customFieldGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //InsertEnumOptionForCustomFieldRequest? insertEnumOptionForCustomFieldRequest = null;
            //var response = instance.InsertEnumOptionForCustomField(customFieldGid, optPretty, optFields, insertEnumOptionForCustomFieldRequest);
            //Assert.IsType<CreateEnumOptionForCustomField201Response>(response);
        }

        /// <summary>
        /// Test UpdateCustomField
        /// </summary>
        [Fact]
        public void UpdateCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string customFieldGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //CreateCustomFieldRequest? createCustomFieldRequest = null;
            //var response = instance.UpdateCustomField(customFieldGid, optPretty, optFields, createCustomFieldRequest);
            //Assert.IsType<CreateCustomField201Response>(response);
        }

        /// <summary>
        /// Test UpdateEnumOption
        /// </summary>
        [Fact]
        public void UpdateEnumOptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string enumOptionGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //UpdateEnumOptionRequest? updateEnumOptionRequest = null;
            //var response = instance.UpdateEnumOption(enumOptionGid, optPretty, optFields, updateEnumOptionRequest);
            //Assert.IsType<CreateEnumOptionForCustomField201Response>(response);
        }
    }
}
