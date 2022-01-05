# Merge.HRISClient.Api.EmployeesApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmployeesList**](EmployeesApi.md#employeeslist) | **GET** /employees | 
[**EmployeesRetrieve**](EmployeesApi.md#employeesretrieve) | **GET** /employees/{id} | 


<a name="employeeslist"></a>
# **EmployeesList**
> PaginatedEmployeeList EmployeesList (string xAccountToken, string companyId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, bool? includeSensitiveFields = null, string managerId = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string payGroupId = null, string personalEmail = null, string remoteId = null, string teamId = null, string workEmail = null, string workLocationId = null)



Returns a list of `Employee` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class EmployeesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmployeesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var companyId = companyId_example;  // string | If provided, will only return employees for this company. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was deleted in the third-party service. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeSensitiveFields = true;  // bool? | Whether to include sensitive fields (such as social security numbers) in the response. (optional) 
            var managerId = managerId_example;  // string | If provided, will only return employees for this manager. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified after this datetime. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified before this datetime. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var payGroupId = payGroupId_example;  // string | If provided, will only return employees for this pay group (optional) 
            var personalEmail = new string(); // string | If provided, will only return Employees with this personal email (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var teamId = teamId_example;  // string | If provided, will only return employees for this team. (optional) 
            var workEmail = new string(); // string | If provided, will only return Employees with this work email (optional) 
            var workLocationId = workLocationId_example;  // string | If provided, will only return employees for this location. (optional) 

            try
            {
                PaginatedEmployeeList result = apiInstance.EmployeesList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, includeSensitiveFields, managerId, modifiedAfter, modifiedBefore, pageSize, payGroupId, personalEmail, remoteId, teamId, workEmail, workLocationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesList: " + e.Message );
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
 **companyId** | **string**| If provided, will only return employees for this company. | [optional] 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was deleted in the third-party service. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **includeSensitiveFields** | **bool?**| Whether to include sensitive fields (such as social security numbers) in the response. | [optional] 
 **managerId** | **string**| If provided, will only return employees for this manager. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, will only return objects modified after this datetime. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, will only return objects modified before this datetime. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **payGroupId** | **string**| If provided, will only return employees for this pay group | [optional] 
 **personalEmail** | [**string**](string.md)| If provided, will only return Employees with this personal email | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **teamId** | **string**| If provided, will only return employees for this team. | [optional] 
 **workEmail** | [**string**](string.md)| If provided, will only return Employees with this work email | [optional] 
 **workLocationId** | **string**| If provided, will only return employees for this location. | [optional] 

### Return type

[**PaginatedEmployeeList**](PaginatedEmployeeList.md)

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

<a name="employeesretrieve"></a>
# **EmployeesRetrieve**
> Employee EmployeesRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, bool? includeSensitiveFields = null)



Returns an `Employee` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class EmployeesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EmployeesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeSensitiveFields = true;  // bool? | Whether to include sensitive fields (such as social security numbers) in the response. (optional) 

            try
            {
                Employee result = apiInstance.EmployeesRetrieve(xAccountToken, id, includeRemoteData, includeSensitiveFields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesRetrieve: " + e.Message );
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
 **includeSensitiveFields** | **bool?**| Whether to include sensitive fields (such as social security numbers) in the response. | [optional] 

### Return type

[**Employee**](Employee.md)

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

