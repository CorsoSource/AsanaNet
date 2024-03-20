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
    ///  Class for testing ProjectStatusesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectStatusesApiTests : IDisposable
    {
        private ProjectStatusesApi instance;

        public ProjectStatusesApiTests()
        {
            instance = new ProjectStatusesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectStatusesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectStatusesApi
            //Assert.IsType<ProjectStatusesApi>(instance);
        }

        /// <summary>
        /// Test CreateProjectStatusForProject
        /// </summary>
        [Fact]
        public void CreateProjectStatusForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //CreateProjectStatusForProjectRequest createProjectStatusForProjectRequest = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.CreateProjectStatusForProject(projectGid, createProjectStatusForProjectRequest, optPretty, optFields);
            //Assert.IsType<GetProjectStatus200Response>(response);
        }

        /// <summary>
        /// Test DeleteProjectStatus
        /// </summary>
        [Fact]
        public void DeleteProjectStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectStatusGid = null;
            //bool? optPretty = null;
            //var response = instance.DeleteProjectStatus(projectStatusGid, optPretty);
            //Assert.IsType<DeleteAttachment200Response>(response);
        }

        /// <summary>
        /// Test GetProjectStatus
        /// </summary>
        [Fact]
        public void GetProjectStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectStatusGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetProjectStatus(projectStatusGid, optPretty, optFields);
            //Assert.IsType<GetProjectStatus200Response>(response);
        }

        /// <summary>
        /// Test GetProjectStatusesForProject
        /// </summary>
        [Fact]
        public void GetProjectStatusesForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetProjectStatusesForProject(projectGid, optPretty, limit, offset, optFields);
            //Assert.IsType<GetProjectStatusesForProject200Response>(response);
        }
    }
}