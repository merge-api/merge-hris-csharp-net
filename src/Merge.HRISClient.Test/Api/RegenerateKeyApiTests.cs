/*
 * Merge HRIS API
 *
 * The unified API for building rich integrations with multiple HR Information System platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
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

using Merge.HRISClient.Client;
using Merge.HRISClient.Api;
// uncomment below to import models
//using Merge.HRISClient.Model;

namespace Merge.HRISClient.Test.Api
{
    /// <summary>
    ///  Class for testing RegenerateKeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RegenerateKeyApiTests : IDisposable
    {
        private RegenerateKeyApi instance;

        public RegenerateKeyApiTests()
        {
            instance = new RegenerateKeyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RegenerateKeyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RegenerateKeyApi
            //Assert.IsType<RegenerateKeyApi>(instance);
        }

        /// <summary>
        /// Test RegenerateKeyCreate
        /// </summary>
        [Fact]
        public void RegenerateKeyCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoteKeyForRegenerationRequest remoteKeyForRegenerationRequest = null;
            //var response = instance.RegenerateKeyCreate(remoteKeyForRegenerationRequest);
            //Assert.IsType<RemoteKey>(response);
        }
    }
}
