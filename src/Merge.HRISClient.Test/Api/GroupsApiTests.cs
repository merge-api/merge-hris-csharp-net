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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupsApiTests : IDisposable
    {
        private GroupsApi instance;

        public GroupsApiTests()
        {
            instance = new GroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GroupsApi
            //Assert.IsType<GroupsApi>(instance);
        }

        /// <summary>
        /// Test GroupsList
        /// </summary>
        [Fact]
        public void GroupsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteFields = null;
            //string remoteId = null;
            //string showEnumOrigins = null;
            //string types = null;
            //var response = instance.GroupsList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, showEnumOrigins, types);
            //Assert.IsType<PaginatedGroupList>(response);
        }

        /// <summary>
        /// Test GroupsRetrieve
        /// </summary>
        [Fact]
        public void GroupsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //string remoteFields = null;
            //string showEnumOrigins = null;
            //var response = instance.GroupsRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
            //Assert.IsType<Group>(response);
        }
    }
}
