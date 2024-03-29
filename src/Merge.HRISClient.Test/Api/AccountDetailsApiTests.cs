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
    ///  Class for testing AccountDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountDetailsApiTests : IDisposable
    {
        private AccountDetailsApi instance;

        public AccountDetailsApiTests()
        {
            instance = new AccountDetailsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountDetailsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountDetailsApi
            //Assert.IsType<AccountDetailsApi>(instance);
        }

        /// <summary>
        /// Test AccountDetailsRetrieve
        /// </summary>
        [Fact]
        public void AccountDetailsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.AccountDetailsRetrieve(xAccountToken);
            //Assert.IsType<AccountDetails>(response);
        }
    }
}
