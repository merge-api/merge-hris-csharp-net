# Merge.HRISClient.Api.LinkedAccountsApi

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LinkedAccountsList**](LinkedAccountsApi.md#linkedaccountslist) | **GET** /linked-accounts | 


<a name="linkedaccountslist"></a>
# **LinkedAccountsList**
> PaginatedAccountDetailsAndActionsList LinkedAccountsList (string category = null, string cursor = null, string endUserEmailAddress = null, string endUserOrganizationName = null, string endUserOriginId = null, string endUserOriginIds = null, Guid? id = null, string ids = null, bool? includeDuplicates = null, string integrationName = null, string isTestAccount = null, int? pageSize = null, string status = null)



List linked accounts for your organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class LinkedAccountsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new LinkedAccountsApi(config);
            var category = category_example;  // string | Options: ('hris', 'ats', 'accounting', 'ticketing', 'crm', 'mktg', 'filestorage')  * `hris` - hris * `ats` - ats * `accounting` - accounting * `ticketing` - ticketing * `crm` - crm * `mktg` - mktg * `filestorage` - filestorage (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var endUserEmailAddress = endUserEmailAddress_example;  // string | If provided, will only return linked accounts associated with the given email address. (optional) 
            var endUserOrganizationName = endUserOrganizationName_example;  // string | If provided, will only return linked accounts associated with the given organization name. (optional) 
            var endUserOriginId = endUserOriginId_example;  // string | If provided, will only return linked accounts associated with the given origin ID. (optional) 
            var endUserOriginIds = endUserOriginIds_example;  // string | Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once. (optional) 
            var id = new Guid?(); // Guid? |  (optional) 
            var ids = ids_example;  // string | Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once. (optional) 
            var includeDuplicates = true;  // bool? | If `true`, will include complete production duplicates of the account specified by the `id` query parameter in the response. `id` must be for a complete production linked account. (optional) 
            var integrationName = integrationName_example;  // string | If provided, will only return linked accounts associated with the given integration name. (optional) 
            var isTestAccount = isTestAccount_example;  // string | If included, will only include test linked accounts. If not included, will only include non-test linked accounts. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var status = status_example;  // string | Filter by status. Options: `COMPLETE`, `INCOMPLETE`, `RELINK_NEEDED` (optional) 

            try
            {
                PaginatedAccountDetailsAndActionsList result = apiInstance.LinkedAccountsList(category, cursor, endUserEmailAddress, endUserOrganizationName, endUserOriginId, endUserOriginIds, id, ids, includeDuplicates, integrationName, isTestAccount, pageSize, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinkedAccountsApi.LinkedAccountsList: " + e.Message );
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
 **category** | **string**| Options: (&#39;hris&#39;, &#39;ats&#39;, &#39;accounting&#39;, &#39;ticketing&#39;, &#39;crm&#39;, &#39;mktg&#39;, &#39;filestorage&#39;)  * &#x60;hris&#x60; - hris * &#x60;ats&#x60; - ats * &#x60;accounting&#x60; - accounting * &#x60;ticketing&#x60; - ticketing * &#x60;crm&#x60; - crm * &#x60;mktg&#x60; - mktg * &#x60;filestorage&#x60; - filestorage | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **endUserEmailAddress** | **string**| If provided, will only return linked accounts associated with the given email address. | [optional] 
 **endUserOrganizationName** | **string**| If provided, will only return linked accounts associated with the given organization name. | [optional] 
 **endUserOriginId** | **string**| If provided, will only return linked accounts associated with the given origin ID. | [optional] 
 **endUserOriginIds** | **string**| Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once. | [optional] 
 **id** | [**Guid?**](Guid?.md)|  | [optional] 
 **ids** | **string**| Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once. | [optional] 
 **includeDuplicates** | **bool?**| If &#x60;true&#x60;, will include complete production duplicates of the account specified by the &#x60;id&#x60; query parameter in the response. &#x60;id&#x60; must be for a complete production linked account. | [optional] 
 **integrationName** | **string**| If provided, will only return linked accounts associated with the given integration name. | [optional] 
 **isTestAccount** | **string**| If included, will only include test linked accounts. If not included, will only include non-test linked accounts. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **status** | **string**| Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; | [optional] 

### Return type

[**PaginatedAccountDetailsAndActionsList**](PaginatedAccountDetailsAndActionsList.md)

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

