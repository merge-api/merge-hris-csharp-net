# Merge.HRISClient.Api.BankInfoApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BankInfoList**](BankInfoApi.md#bankinfolist) | **GET** /bank-info | 
[**BankInfoRetrieve**](BankInfoApi.md#bankinforetrieve) | **GET** /bank-info/{id} | 


<a name="bankinfolist"></a>
# **BankInfoList**
> PaginatedBankInfoList BankInfoList (string xAccountToken, string accountType = null, string bankName = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, string employeeId = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, string orderBy = null, int? pageSize = null, string remoteFields = null, string remoteId = null, string showEnumOrigins = null)



Returns a list of `BankInfo` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class BankInfoListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankInfoApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var accountType = accountType_example;  // string | If provided, will only return BankInfo's with this account type. Options: ('SAVINGS', 'CHECKING')  * `SAVINGS` - SAVINGS * `CHECKING` - CHECKING (optional) 
            var bankName = bankName_example;  // string | If provided, will only return BankInfo's with this bank name. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var employeeId = employeeId_example;  // string | If provided, will only return bank accounts for this employee. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge after this date time will be returned. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge before this date time will be returned. (optional) 
            var orderBy = orderBy_example;  // string | Overrides the default ordering for this endpoint. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteFields = account_type;  // string | Deprecated. Use show_enum_origins. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var showEnumOrigins = account_type;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                PaginatedBankInfoList result = apiInstance.BankInfoList(xAccountToken, accountType, bankName, createdAfter, createdBefore, cursor, employeeId, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, orderBy, pageSize, remoteFields, remoteId, showEnumOrigins);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankInfoApi.BankInfoList: " + e.Message );
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
 **accountType** | **string**| If provided, will only return BankInfo&#39;s with this account type. Options: (&#39;SAVINGS&#39;, &#39;CHECKING&#39;)  * &#x60;SAVINGS&#x60; - SAVINGS * &#x60;CHECKING&#x60; - CHECKING | [optional] 
 **bankName** | **string**| If provided, will only return BankInfo&#39;s with this bank name. | [optional] 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **employeeId** | **string**| If provided, will only return bank accounts for this employee. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **orderBy** | **string**| Overrides the default ordering for this endpoint. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 

### Return type

[**PaginatedBankInfoList**](PaginatedBankInfoList.md)

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

<a name="bankinforetrieve"></a>
# **BankInfoRetrieve**
> BankInfo BankInfoRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, string remoteFields = null, string showEnumOrigins = null)



Returns a `BankInfo` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class BankInfoRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BankInfoApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var remoteFields = account_type;  // string | Deprecated. Use show_enum_origins. (optional) 
            var showEnumOrigins = account_type;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                BankInfo result = apiInstance.BankInfoRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BankInfoApi.BankInfoRetrieve: " + e.Message );
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
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 

### Return type

[**BankInfo**](BankInfo.md)

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

