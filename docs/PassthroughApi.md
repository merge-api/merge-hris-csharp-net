# Merge.HRISClient.Api.PassthroughApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PassthroughCreate**](PassthroughApi.md#passthroughcreate) | **POST** /passthrough | 


<a name="passthroughcreate"></a>
# **PassthroughCreate**
> RemoteResponse PassthroughCreate (string xAccountToken, DataPassthroughRequest dataPassthroughRequest)



Pull data from an endpoint not currently supported by Merge.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class PassthroughCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PassthroughApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var dataPassthroughRequest = new DataPassthroughRequest(); // DataPassthroughRequest | 

            try
            {
                RemoteResponse result = apiInstance.PassthroughCreate(xAccountToken, dataPassthroughRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PassthroughApi.PassthroughCreate: " + e.Message );
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
 **dataPassthroughRequest** | [**DataPassthroughRequest**](DataPassthroughRequest.md)|  | 

### Return type

[**RemoteResponse**](RemoteResponse.md)

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

