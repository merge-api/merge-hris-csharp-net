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
    ///  Class for testing PayrollRunsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PayrollRunsApiTests : IDisposable
    {
        private PayrollRunsApi instance;

        public PayrollRunsApiTests()
        {
            instance = new PayrollRunsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PayrollRunsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PayrollRunsApi
            //Assert.IsType<PayrollRunsApi>(instance);
        }

        /// <summary>
        /// Test PayrollRunsList
        /// </summary>
        [Fact]
        public void PayrollRunsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.PayrollRunsList(xAccountToken, createdAfter, createdBefore, cursor, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedPayrollRunList>(response);
        }

        /// <summary>
        /// Test PayrollRunsRetrieve
        /// </summary>
        [Fact]
        public void PayrollRunsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.PayrollRunsRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<PayrollRun>(response);
        }
    }
}
