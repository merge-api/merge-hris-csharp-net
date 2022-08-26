# Merge.HRISClient.Api.IssuesApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IssuesList**](IssuesApi.md#issueslist) | **GET** /issues | 
[**IssuesRetrieve**](IssuesApi.md#issuesretrieve) | **GET** /issues/{id} | 


<a name="issueslist"></a>
# **IssuesList**
> PaginatedIssueList IssuesList (string accountToken = null, string cursor = null, string endDate = null, string endUserOrganizationName = null, DateTime? firstIncidentTimeAfter = null, DateTime? firstIncidentTimeBefore = null, string includeMuted = null, string integrationName = null, DateTime? lastIncidentTimeAfter = null, DateTime? lastIncidentTimeBefore = null, int? pageSize = null, string startDate = null, string status = null)



Gets issues.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class IssuesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var accountToken = accountToken_example;  // string |  (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var endDate = endDate_example;  // string | If included, will only include issues whose most recent action occurred before this time (optional) 
            var endUserOrganizationName = endUserOrganizationName_example;  // string |  (optional) 
            var firstIncidentTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return issues whose first incident time was after this datetime. (optional) 
            var firstIncidentTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return issues whose first incident time was before this datetime. (optional) 
            var includeMuted = includeMuted_example;  // string | If True, will include muted issues (optional) 
            var integrationName = integrationName_example;  // string |  (optional) 
            var lastIncidentTimeAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return issues whose first incident time was after this datetime. (optional) 
            var lastIncidentTimeBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return issues whose first incident time was before this datetime. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var startDate = startDate_example;  // string | If included, will only include issues whose most recent action occurred after this time (optional) 
            var status = status_example;  // string |  (optional) 

            try
            {
                PaginatedIssueList result = apiInstance.IssuesList(accountToken, cursor, endDate, endUserOrganizationName, firstIncidentTimeAfter, firstIncidentTimeBefore, includeMuted, integrationName, lastIncidentTimeAfter, lastIncidentTimeBefore, pageSize, startDate, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesList: " + e.Message );
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
 **accountToken** | **string**|  | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **endDate** | **string**| If included, will only include issues whose most recent action occurred before this time | [optional] 
 **endUserOrganizationName** | **string**|  | [optional] 
 **firstIncidentTimeAfter** | **DateTime?**| If provided, will only return issues whose first incident time was after this datetime. | [optional] 
 **firstIncidentTimeBefore** | **DateTime?**| If provided, will only return issues whose first incident time was before this datetime. | [optional] 
 **includeMuted** | **string**| If True, will include muted issues | [optional] 
 **integrationName** | **string**|  | [optional] 
 **lastIncidentTimeAfter** | **DateTime?**| If provided, will only return issues whose first incident time was after this datetime. | [optional] 
 **lastIncidentTimeBefore** | **DateTime?**| If provided, will only return issues whose first incident time was before this datetime. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **startDate** | **string**| If included, will only include issues whose most recent action occurred after this time | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**PaginatedIssueList**](PaginatedIssueList.md)

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

<a name="issuesretrieve"></a>
# **IssuesRetrieve**
> Issue IssuesRetrieve (Guid id)



Get a specific issue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class IssuesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new IssuesApi(config);
            var id = new Guid(); // Guid | 

            try
            {
                Issue result = apiInstance.IssuesRetrieve(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssuesApi.IssuesRetrieve: " + e.Message );
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
 **id** | [**Guid**](Guid.md)|  | 

### Return type

[**Issue**](Issue.md)

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

