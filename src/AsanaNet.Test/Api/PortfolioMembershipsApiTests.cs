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
    ///  Class for testing PortfolioMembershipsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PortfolioMembershipsApiTests : IDisposable
    {
        private PortfolioMembershipsApi instance;

        public PortfolioMembershipsApiTests()
        {
            instance = new PortfolioMembershipsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PortfolioMembershipsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PortfolioMembershipsApi
            //Assert.IsType<PortfolioMembershipsApi>(instance);
        }

        /// <summary>
        /// Test GetPortfolioMembership
        /// </summary>
        [Fact]
        public void GetPortfolioMembershipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string portfolioMembershipGid = null;
            //bool? optPretty = null;
            //List<string>? optFields = null;
            //var response = instance.GetPortfolioMembership(portfolioMembershipGid, optPretty, optFields);
            //Assert.IsType<GetPortfolioMembership200Response>(response);
        }

        /// <summary>
        /// Test GetPortfolioMemberships
        /// </summary>
        [Fact]
        public void GetPortfolioMembershipsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? portfolio = null;
            //string? workspace = null;
            //string? user = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetPortfolioMemberships(portfolio, workspace, user, optPretty, limit, offset, optFields);
            //Assert.IsType<GetPortfolioMemberships200Response>(response);
        }

        /// <summary>
        /// Test GetPortfolioMembershipsForPortfolio
        /// </summary>
        [Fact]
        public void GetPortfolioMembershipsForPortfolioTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string portfolioGid = null;
            //string? user = null;
            //bool? optPretty = null;
            //int? limit = null;
            //string? offset = null;
            //List<string>? optFields = null;
            //var response = instance.GetPortfolioMembershipsForPortfolio(portfolioGid, user, optPretty, limit, offset, optFields);
            //Assert.IsType<GetPortfolioMemberships200Response>(response);
        }
    }
}
