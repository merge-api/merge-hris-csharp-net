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

namespace Merge.HRISClient.Test.Api
{
    /// <summary>
    ///  Class for testing DeleteAccountApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeleteAccountApiTests : IDisposable
    {
        private DeleteAccountApi instance;

        public DeleteAccountApiTests()
        {
            instance = new DeleteAccountApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeleteAccountApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DeleteAccountApi
            //Assert.IsType<DeleteAccountApi>(instance);
        }

        /// <summary>
        /// Test DeleteAccountCreate
        /// </summary>
        [Fact]
        public void DeleteAccountCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //instance.DeleteAccountCreate(xAccountToken);
        }
    }
}