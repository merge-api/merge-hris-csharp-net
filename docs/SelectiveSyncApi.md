# Merge.HRISClient.Api.SelectiveSyncApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SelectiveSyncConfigurationsList**](SelectiveSyncApi.md#selectivesyncconfigurationslist) | **GET** /selective-sync/configurations | 
[**SelectiveSyncConfigurationsUpdate**](SelectiveSyncApi.md#selectivesyncconfigurationsupdate) | **PUT** /selective-sync/configurations | 
[**SelectiveSyncMetaList**](SelectiveSyncApi.md#selectivesyncmetalist) | **GET** /selective-sync/meta | 


<a name="selectivesyncconfigurationslist"></a>
# **SelectiveSyncConfigurationsList**
> List&lt;LinkedAccountSelectiveSyncConfiguration&gt; SelectiveSyncConfigurationsList (string xAccountToken)



Get a linked account's selective syncs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class SelectiveSyncConfigurationsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SelectiveSyncApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.

            try
            {
                List<LinkedAccountSelectiveSyncConfiguration> result = apiInstance.SelectiveSyncConfigurationsList(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.SelectiveSyncConfigurationsList: " + e.Message );
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

### Return type

[**List&lt;LinkedAccountSelectiveSyncConfiguration&gt;**](LinkedAccountSelectiveSyncConfiguration.md)

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

<a name="selectivesyncconfigurationsupdate"></a>
# **SelectiveSyncConfigurationsUpdate**
> List&lt;LinkedAccountSelectiveSyncConfiguration&gt; SelectiveSyncConfigurationsUpdate (string xAccountToken, LinkedAccountSelectiveSyncConfigurationListRequest linkedAccountSelectiveSyncConfigurationListRequest)



Replace a linked account's selective syncs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class SelectiveSyncConfigurationsUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SelectiveSyncApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var linkedAccountSelectiveSyncConfigurationListRequest = new LinkedAccountSelectiveSyncConfigurationListRequest(); // LinkedAccountSelectiveSyncConfigurationListRequest | 

            try
            {
                List<LinkedAccountSelectiveSyncConfiguration> result = apiInstance.SelectiveSyncConfigurationsUpdate(xAccountToken, linkedAccountSelectiveSyncConfigurationListRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.SelectiveSyncConfigurationsUpdate: " + e.Message );
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
 **linkedAccountSelectiveSyncConfigurationListRequest** | [**LinkedAccountSelectiveSyncConfigurationListRequest**](LinkedAccountSelectiveSyncConfigurationListRequest.md)|  | 

### Return type

[**List&lt;LinkedAccountSelectiveSyncConfiguration&gt;**](LinkedAccountSelectiveSyncConfiguration.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="selectivesyncmetalist"></a>
# **SelectiveSyncMetaList**
> PaginatedConditionSchemaList SelectiveSyncMetaList (string xAccountToken, string commonModel = null, string cursor = null, int? pageSize = null)



Get metadata for the conditions available to a linked account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class SelectiveSyncMetaListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new SelectiveSyncApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var commonModel = commonModel_example;  // string |  (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 

            try
            {
                PaginatedConditionSchemaList result = apiInstance.SelectiveSyncMetaList(xAccountToken, commonModel, cursor, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SelectiveSyncApi.SelectiveSyncMetaList: " + e.Message );
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
 **commonModel** | **string**|  | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 

### Return type

[**PaginatedConditionSchemaList**](PaginatedConditionSchemaList.md)

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

