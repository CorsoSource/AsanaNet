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
    ///  Class for testing ProjectMembershipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectMembershipsApiTests : IDisposable
    {
        private ProjectMembershipsApi instance;

        public ProjectMembershipsApiTests()
        {
            instance = new ProjectMembershipsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectMembershipsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectMembershipsApi
            //Assert.IsType<ProjectMembershipsApi>(instance);
        }

        /// <summary>
        /// Test GetProjectMembership
        /// </summary>
        [Fact]
        public void GetProjectMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectMembershipGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetProjectMembership(projectMembershipGid, optPretty, optFields);
            //Assert.IsType<GetProjectMembership200Response>(response);
        }

        /// <summary>
        /// Test GetProjectMembershipsForProject
        /// </summary>
        [Fact]
        public void GetProjectMembershipsForProjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string projectGid = null;
            //string? user = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetProjectMembershipsForProject(projectGid, user, optPretty, limit, offset, optFields);
            //Assert.IsType<GetProjectMembershipsForProject200Response>(response);
        }
    }
}
