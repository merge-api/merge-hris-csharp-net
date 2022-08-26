# Merge.HRISClient.Api.PayrollRunsApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PayrollRunsList**](PayrollRunsApi.md#payrollrunslist) | **GET** /payroll-runs | 
[**PayrollRunsRetrieve**](PayrollRunsApi.md#payrollrunsretrieve) | **GET** /payroll-runs/{id} | 


<a name="payrollrunslist"></a>
# **PayrollRunsList**
> PaginatedPayrollRunList PayrollRunsList (string xAccountToken, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, DateTime? endedAfter = null, DateTime? endedBefore = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteFields = null, string remoteId = null, string runType = null, DateTime? startedAfter = null, DateTime? startedBefore = null)



Returns a list of `PayrollRun` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class PayrollRunsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PayrollRunsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var endedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return payroll runs ended after this datetime. (optional) 
            var endedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return payroll runs ended before this datetime. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified after this datetime. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified before this datetime. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteFields = run_state,run_type;  // string | Which fields should be returned in non-normalized form. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var runType = runType_example;  // string | If provided, will only return PayrollRun's with this status. Options: ('REGULAR', 'OFF_CYCLE', 'CORRECTION', 'TERMINATION', 'SIGN_ON_BONUS') (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return payroll runs started after this datetime. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return payroll runs started before this datetime. (optional) 

            try
            {
                PaginatedPayrollRunList result = apiInstance.PayrollRunsList(xAccountToken, createdAfter, createdBefore, cursor, endedAfter, endedBefore, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, runType, startedAfter, startedBefore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayrollRunsApi.PayrollRunsList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAccountToken** | **string**| Token identifying the end user. | 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **endedAfter** | **DateTime?**| If provided, will only return payroll runs ended after this datetime. | [optional] 
 **endedBefore** | **DateTime?**| If provided, will only return payroll runs ended before this datetime. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, will only return objects modified after this datetime. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, will only return objects modified before this datetime. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteFields** | **string**| Which fields should be returned in non-normalized form. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **runType** | **string**| If provided, will only return PayrollRun&#39;s with this status. Options: (&#39;REGULAR&#39;, &#39;OFF_CYCLE&#39;, &#39;CORRECTION&#39;, &#39;TERMINATION&#39;, &#39;SIGN_ON_BONUS&#39;) | [optional] 
 **startedAfter** | **DateTime?**| If provided, will only return payroll runs started after this datetime. | [optional] 
 **startedBefore** | **DateTime?**| If provided, will only return payroll runs started before this datetime. | [optional] 

### Return type

[**PaginatedPayrollRunList**](PaginatedPayrollRunList.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payrollrunsretrieve"></a>
# **PayrollRunsRetrieve**
> PayrollRun PayrollRunsRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, string remoteFields = null)



Returns a `PayrollRun` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class PayrollRunsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PayrollRunsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var remoteFields = run_state,run_type;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                PayrollRun result = apiInstance.PayrollRunsRetrieve(xAccountToken, id, includeRemoteData, remoteFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PayrollRunsApi.PayrollRunsRetrieve: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAccountToken** | **string**| Token identifying the end user. | 
 **id** | [**Guid**](Guid.md)|  | 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **remoteFields** | **string**| Which fields should be returned in non-normalized form. | [optional] 

### Return type

[**PayrollRun**](PayrollRun.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

