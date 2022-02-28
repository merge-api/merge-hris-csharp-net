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
    ///  Class for testing TimeOffApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TimeOffApiTests : IDisposable
    {
        private TimeOffApi instance;

        public TimeOffApiTests()
        {
            instance = new TimeOffApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TimeOffApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TimeOffApi
            //Assert.IsType<TimeOffApi>(instance);
        }

        /// <summary>
        /// Test TimeOffCreate
        /// </summary>
        [Fact]
        public void TimeOffCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //TimeOffEndpointRequest timeOffEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.TimeOffCreate(xAccountToken, timeOffEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<TimeOffResponse>(response);
        }

        /// <summary>
        /// Test TimeOffList
        /// </summary>
        [Fact]
        public void TimeOffListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string approverId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //string employeeId = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //string requestType = null;
            //string status = null;
            //var response = instance.TimeOffList(xAccountToken, approverId, createdAfter, createdBefore, cursor, employeeId, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId, requestType, status);
            //Assert.IsType<PaginatedTimeOffList>(response);
        }

        /// <summary>
        /// Test TimeOffRetrieve
        /// </summary>
        [Fact]
        public void TimeOffRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.TimeOffRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<TimeOff>(response);
        }
    }
}
