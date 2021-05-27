# Merge.HRISClient.Api.RegenerateKeyApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RegenerateKeyCreate**](RegenerateKeyApi.md#regeneratekeycreate) | **POST** /regenerate-key | 


<a name="regeneratekeycreate"></a>
# **RegenerateKeyCreate**
> RemoteKey RegenerateKeyCreate (RemoteKeyForRegenerationRequest remoteKeyForRegenerationRequest)



Exchange remote keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class RegenerateKeyCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RegenerateKeyApi(config);
            var remoteKeyForRegenerationRequest = new RemoteKeyForRegenerationRequest(); // RemoteKeyForRegenerationRequest | 

            try
            {
                RemoteKey result = apiInstance.RegenerateKeyCreate(remoteKeyForRegenerationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegenerateKeyApi.RegenerateKeyCreate: " + e.Message );
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
 **remoteKeyForRegenerationRequest** | [**RemoteKeyForRegenerationRequest**](RemoteKeyForRegenerationRequest.md)|  | 

### Return type

[**RemoteKey**](RemoteKey.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

