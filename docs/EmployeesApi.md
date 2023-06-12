# Merge.HRISClient.Api.EmployeesApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmployeesCreate**](EmployeesApi.md#employeescreate) | **POST** /employees | 
[**EmployeesIgnoreCreate**](EmployeesApi.md#employeesignorecreate) | **POST** /employees/ignore/{model_id} | 
[**EmployeesList**](EmployeesApi.md#employeeslist) | **GET** /employees | 
[**EmployeesMetaPostRetrieve**](EmployeesApi.md#employeesmetapostretrieve) | **GET** /employees/meta/post | 
[**EmployeesRetrieve**](EmployeesApi.md#employeesretrieve) | **GET** /employees/{id} | 


<a name="employeescreate"></a>
# **EmployeesCreate**
> EmployeeResponse EmployeesCreate (string xAccountToken, EmployeeEndpointRequest employeeEndpointRequest, bool? isDebugMode = null, bool? runAsync = null)



Creates an `Employee` object with the given values.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class EmployeesCreateExample
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
            var employeeEndpointRequest = new EmployeeEndpointRequest(); // EmployeeEndpointRequest | 
            var isDebugMode = true;  // bool? | Whether to include debug fields (such as log file links) in the response. (optional) 
            var runAsync = true;  // bool? | Whether or not third-party updates should be run asynchronously. (optional) 

            try
            {
                EmployeeResponse result = apiInstance.EmployeesCreate(xAccountToken, employeeEndpointRequest, isDebugMode, runAsync);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesCreate: " + e.Message );
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
 **employeeEndpointRequest** | [**EmployeeEndpointRequest**](EmployeeEndpointRequest.md)|  | 
 **isDebugMode** | **bool?**| Whether to include debug fields (such as log file links) in the response. | [optional] 
 **runAsync** | **bool?**| Whether or not third-party updates should be run asynchronously. | [optional] 

### Return type

[**EmployeeResponse**](EmployeeResponse.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesignorecreate"></a>
# **EmployeesIgnoreCreate**
> void EmployeesIgnoreCreate (string xAccountToken, Guid modelId, IgnoreCommonModelRequest ignoreCommonModelRequest)



Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The \"reason\" and \"message\" fields in the request body will be stored for audit purposes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class EmployeesIgnoreCreateExample
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
            var modelId = new Guid(); // Guid | 
            var ignoreCommonModelRequest = new IgnoreCommonModelRequest(); // IgnoreCommonModelRequest | 

            try
            {
                apiInstance.EmployeesIgnoreCreate(xAccountToken, modelId, ignoreCommonModelRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesIgnoreCreate: " + e.Message );
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
 **modelId** | [**Guid**](Guid.md)|  | 
 **ignoreCommonModelRequest** | [**IgnoreCommonModelRequest**](IgnoreCommonModelRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded, multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | No response body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeeslist"></a>
# **EmployeesList**
> PaginatedEmployeeList EmployeesList (string xAccountToken, string companyId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, string displayFullName = null, string employmentStatus = null, string firstName = null, string groups = null, bool? includeDeletedData = null, bool? includeRemoteData = null, bool? includeSensitiveFields = null, string lastName = null, string managerId = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string payGroupId = null, string personalEmail = null, string remoteFields = null, string remoteId = null, string showEnumOrigins = null, DateTime? startedAfter = null, DateTime? startedBefore = null, string teamId = null, DateTime? terminatedAfter = null, DateTime? terminatedBefore = null, string workEmail = null, string workLocationId = null)



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
            var displayFullName = displayFullName_example;  // string | If provided, will only return employees with this display name. (optional) 
            var employmentStatus = employmentStatus_example;  // string | If provided, will only return employees with this employment status.  * `ACTIVE` - ACTIVE * `PENDING` - PENDING * `INACTIVE` - INACTIVE (optional) 
            var firstName = firstName_example;  // string | If provided, will only return employees with this first name. (optional) 
            var groups = groups_example;  // string | If provided, will only return employees matching the group ids; multiple groups can be separated by commas. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var includeSensitiveFields = true;  // bool? | Whether to include sensitive fields (such as social security numbers) in the response. (optional) 
            var lastName = lastName_example;  // string | If provided, will only return employees with this last name. (optional) 
            var managerId = managerId_example;  // string | If provided, will only return employees for this manager. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge after this date time will be returned. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge before this date time will be returned. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var payGroupId = payGroupId_example;  // string | If provided, will only return employees for this pay group (optional) 
            var personalEmail = new string(); // string | If provided, will only return Employees with this personal email (optional) 
            var remoteFields = employment_status,ethnicity,gender,marital_status;  // string | Deprecated. Use show_enum_origins. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var showEnumOrigins = employment_status,ethnicity,gender,marital_status;  // string | Which fields should be returned in non-normalized form. (optional) 
            var startedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return employees that started after this datetime. (optional) 
            var startedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return employees that started before this datetime. (optional) 
            var teamId = teamId_example;  // string | If provided, will only return employees for this team. (optional) 
            var terminatedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return employees that were terminated after this datetime. (optional) 
            var terminatedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return employees that were terminated before this datetime. (optional) 
            var workEmail = new string(); // string | If provided, will only return Employees with this work email (optional) 
            var workLocationId = workLocationId_example;  // string | If provided, will only return employees for this location. (optional) 

            try
            {
                PaginatedEmployeeList result = apiInstance.EmployeesList(xAccountToken, companyId, createdAfter, createdBefore, cursor, displayFullName, employmentStatus, firstName, groups, includeDeletedData, includeRemoteData, includeSensitiveFields, lastName, managerId, modifiedAfter, modifiedBefore, pageSize, payGroupId, personalEmail, remoteFields, remoteId, showEnumOrigins, startedAfter, startedBefore, teamId, terminatedAfter, terminatedBefore, workEmail, workLocationId);
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
 **displayFullName** | **string**| If provided, will only return employees with this display name. | [optional] 
 **employmentStatus** | **string**| If provided, will only return employees with this employment status.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;PENDING&#x60; - PENDING * &#x60;INACTIVE&#x60; - INACTIVE | [optional] 
 **firstName** | **string**| If provided, will only return employees with this first name. | [optional] 
 **groups** | **string**| If provided, will only return employees matching the group ids; multiple groups can be separated by commas. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **includeSensitiveFields** | **bool?**| Whether to include sensitive fields (such as social security numbers) in the response. | [optional] 
 **lastName** | **string**| If provided, will only return employees with this last name. | [optional] 
 **managerId** | **string**| If provided, will only return employees for this manager. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **payGroupId** | **string**| If provided, will only return employees for this pay group | [optional] 
 **personalEmail** | [**string**](string.md)| If provided, will only return Employees with this personal email | [optional] 
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 
 **startedAfter** | **DateTime?**| If provided, will only return employees that started after this datetime. | [optional] 
 **startedBefore** | **DateTime?**| If provided, will only return employees that started before this datetime. | [optional] 
 **teamId** | **string**| If provided, will only return employees for this team. | [optional] 
 **terminatedAfter** | **DateTime?**| If provided, will only return employees that were terminated after this datetime. | [optional] 
 **terminatedBefore** | **DateTime?**| If provided, will only return employees that were terminated before this datetime. | [optional] 
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

<a name="employeesmetapostretrieve"></a>
# **EmployeesMetaPostRetrieve**
> MetaResponse EmployeesMetaPostRetrieve (string xAccountToken)



Returns metadata for `Employee` POSTs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class EmployeesMetaPostRetrieveExample
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

            try
            {
                MetaResponse result = apiInstance.EmployeesMetaPostRetrieve(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesMetaPostRetrieve: " + e.Message );
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

[**MetaResponse**](MetaResponse.md)

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
> Employee EmployeesRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, bool? includeSensitiveFields = null, string remoteFields = null, string showEnumOrigins = null)



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
            var remoteFields = employment_status,ethnicity,gender,marital_status;  // string | Deprecated. Use show_enum_origins. (optional) 
            var showEnumOrigins = employment_status,ethnicity,gender,marital_status;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                Employee result = apiInstance.EmployeesRetrieve(xAccountToken, id, includeRemoteData, includeSensitiveFields, remoteFields, showEnumOrigins);
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
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 

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

