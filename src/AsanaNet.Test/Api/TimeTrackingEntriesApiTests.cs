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
    ///  Class for testing TimeTrackingEntriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TimeTrackingEntriesApiTests : IDisposable
    {
        private TimeTrackingEntriesApi instance;

        public TimeTrackingEntriesApiTests()
        {
            instance = new TimeTrackingEntriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimeTrackingEntriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TimeTrackingEntriesApi
            //Assert.IsType<TimeTrackingEntriesApi>(instance);
        }

        /// <summary>
        /// Test CreateTimeTrackingEntry
        /// </summary>
        [Fact]
        public void CreateTimeTrackingEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //CreateTimeTrackingEntryRequest createTimeTrackingEntryRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateTimeTrackingEntry(taskGid, createTimeTrackingEntryRequest, optPretty, optFields);
            //Assert.IsType<CreateTimeTrackingEntry201Response>(response);
        }

        /// <summary>
        /// Test DeleteTimeTrackingEntry
        /// </summary>
        [Fact]
        public void DeleteTimeTrackingEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeTrackingEntryGid = null;
            //bool? optPretty = null;
            //var response = instance.DeleteTimeTrackingEntry(timeTrackingEntryGid, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test GetTimeTrackingEntriesForTask
        /// </summary>
        [Fact]
        public void GetTimeTrackingEntriesForTaskTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetTimeTrackingEntriesForTask(taskGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetTimeTrackingEntriesForTask200Response>(response);
        }

        /// <summary>
        /// Test GetTimeTrackingEntry
        /// </summary>
        [Fact]
        public void GetTimeTrackingEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeTrackingEntryGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetTimeTrackingEntry(timeTrackingEntryGid, optPretty, optFields);
            //Assert.IsType<CreateTimeTrackingEntry201Response>(response);
        }

        /// <summary>
        /// Test UpdateTimeTrackingEntry
        /// </summary>
        [Fact]
        public void UpdateTimeTrackingEntryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timeTrackingEntryGid = null;
            //UpdateTimeTrackingEntryRequest updateTimeTrackingEntryRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.UpdateTimeTrackingEntry(timeTrackingEntryGid, updateTimeTrackingEntryRequest, optPretty, optFields);
            //Assert.IsType<CreateTimeTrackingEntry201Response>(response);
        }
    }
}
