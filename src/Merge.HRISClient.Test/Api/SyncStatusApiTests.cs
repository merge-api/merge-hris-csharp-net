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
    ///  Class for testing SyncStatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SyncStatusApiTests : IDisposable
    {
        private SyncStatusApi instance;

        public SyncStatusApiTests()
        {
            instance = new SyncStatusApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SyncStatusApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SyncStatusApi
            //Assert.IsType<SyncStatusApi>(instance);
        }

        /// <summary>
        /// Test SyncStatusResyncCreate
        /// </summary>
        [Fact]
        public void SyncStatusResyncCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.SyncStatusResyncCreate(xAccountToken);
            //Assert.IsType<SyncStatus>(response);
        }

        /// <summary>
        /// Test SyncStatusRetrieve
        /// </summary>
        [Fact]
        public void SyncStatusRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.SyncStatusRetrieve(xAccountToken);
            //Assert.IsType<SyncStatus>(response);
        }
    }
}
