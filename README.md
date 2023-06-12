# Merge.HRISClient - the C# library for the Merge HRIS API

The unified API for building rich integrations with multiple HR Information System platforms.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 2.1.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.merge.dev/](https://www.merge.dev/)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.HRISClient.Api;
using Merge.HRISClient.Client;
using Merge.HRISClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/hris/v1";
            // Configure API key authorization: tokenAuth
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountDetailsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.

            try
            {
                AccountDetails result = apiInstance.AccountDetailsRetrieve(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountDetailsApi.AccountDetailsRetrieve: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.merge.dev/api/hris/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountDetailsApi* | [**AccountDetailsRetrieve**](docs/AccountDetailsApi.md#accountdetailsretrieve) | **GET** /account-details | 
*AccountTokenApi* | [**AccountTokenRetrieve**](docs/AccountTokenApi.md#accounttokenretrieve) | **GET** /account-token/{public_token} | 
*AvailableActionsApi* | [**AvailableActionsRetrieve**](docs/AvailableActionsApi.md#availableactionsretrieve) | **GET** /available-actions | 
*BankInfoApi* | [**BankInfoList**](docs/BankInfoApi.md#bankinfolist) | **GET** /bank-info | 
*BankInfoApi* | [**BankInfoRetrieve**](docs/BankInfoApi.md#bankinforetrieve) | **GET** /bank-info/{id} | 
*BenefitsApi* | [**BenefitsList**](docs/BenefitsApi.md#benefitslist) | **GET** /benefits | 
*BenefitsApi* | [**BenefitsRetrieve**](docs/BenefitsApi.md#benefitsretrieve) | **GET** /benefits/{id} | 
*CompaniesApi* | [**CompaniesList**](docs/CompaniesApi.md#companieslist) | **GET** /companies | 
*CompaniesApi* | [**CompaniesRetrieve**](docs/CompaniesApi.md#companiesretrieve) | **GET** /companies/{id} | 
*DeleteAccountApi* | [**DeleteAccountCreate**](docs/DeleteAccountApi.md#deleteaccountcreate) | **POST** /delete-account | 
*EmployeePayrollRunsApi* | [**EmployeePayrollRunsList**](docs/EmployeePayrollRunsApi.md#employeepayrollrunslist) | **GET** /employee-payroll-runs | 
*EmployeePayrollRunsApi* | [**EmployeePayrollRunsRetrieve**](docs/EmployeePayrollRunsApi.md#employeepayrollrunsretrieve) | **GET** /employee-payroll-runs/{id} | 
*EmployeesApi* | [**EmployeesCreate**](docs/EmployeesApi.md#employeescreate) | **POST** /employees | 
*EmployeesApi* | [**EmployeesIgnoreCreate**](docs/EmployeesApi.md#employeesignorecreate) | **POST** /employees/ignore/{model_id} | 
*EmployeesApi* | [**EmployeesList**](docs/EmployeesApi.md#employeeslist) | **GET** /employees | 
*EmployeesApi* | [**EmployeesMetaPostRetrieve**](docs/EmployeesApi.md#employeesmetapostretrieve) | **GET** /employees/meta/post | 
*EmployeesApi* | [**EmployeesRetrieve**](docs/EmployeesApi.md#employeesretrieve) | **GET** /employees/{id} | 
*EmploymentsApi* | [**EmploymentsList**](docs/EmploymentsApi.md#employmentslist) | **GET** /employments | 
*EmploymentsApi* | [**EmploymentsRetrieve**](docs/EmploymentsApi.md#employmentsretrieve) | **GET** /employments/{id} | 
*ForceResyncApi* | [**SyncStatusResyncCreate**](docs/ForceResyncApi.md#syncstatusresynccreate) | **POST** /sync-status/resync | 
*GenerateKeyApi* | [**GenerateKeyCreate**](docs/GenerateKeyApi.md#generatekeycreate) | **POST** /generate-key | 
*GroupsApi* | [**GroupsList**](docs/GroupsApi.md#groupslist) | **GET** /groups | 
*GroupsApi* | [**GroupsRetrieve**](docs/GroupsApi.md#groupsretrieve) | **GET** /groups/{id} | 
*IssuesApi* | [**IssuesList**](docs/IssuesApi.md#issueslist) | **GET** /issues | 
*IssuesApi* | [**IssuesRetrieve**](docs/IssuesApi.md#issuesretrieve) | **GET** /issues/{id} | 
*LinkTokenApi* | [**LinkTokenCreate**](docs/LinkTokenApi.md#linktokencreate) | **POST** /link-token | 
*LinkedAccountsApi* | [**LinkedAccountsList**](docs/LinkedAccountsApi.md#linkedaccountslist) | **GET** /linked-accounts | 
*LocationsApi* | [**LocationsList**](docs/LocationsApi.md#locationslist) | **GET** /locations | 
*LocationsApi* | [**LocationsRetrieve**](docs/LocationsApi.md#locationsretrieve) | **GET** /locations/{id} | 
*PassthroughApi* | [**PassthroughCreate**](docs/PassthroughApi.md#passthroughcreate) | **POST** /passthrough | 
*PayGroupsApi* | [**PayGroupsList**](docs/PayGroupsApi.md#paygroupslist) | **GET** /pay-groups | 
*PayGroupsApi* | [**PayGroupsRetrieve**](docs/PayGroupsApi.md#paygroupsretrieve) | **GET** /pay-groups/{id} | 
*PayrollRunsApi* | [**PayrollRunsList**](docs/PayrollRunsApi.md#payrollrunslist) | **GET** /payroll-runs | 
*PayrollRunsApi* | [**PayrollRunsRetrieve**](docs/PayrollRunsApi.md#payrollrunsretrieve) | **GET** /payroll-runs/{id} | 
*RegenerateKeyApi* | [**RegenerateKeyCreate**](docs/RegenerateKeyApi.md#regeneratekeycreate) | **POST** /regenerate-key | 
*SelectiveSyncApi* | [**SelectiveSyncConfigurationsList**](docs/SelectiveSyncApi.md#selectivesyncconfigurationslist) | **GET** /selective-sync/configurations | 
*SelectiveSyncApi* | [**SelectiveSyncConfigurationsUpdate**](docs/SelectiveSyncApi.md#selectivesyncconfigurationsupdate) | **PUT** /selective-sync/configurations | 
*SelectiveSyncApi* | [**SelectiveSyncMetaList**](docs/SelectiveSyncApi.md#selectivesyncmetalist) | **GET** /selective-sync/meta | 
*SyncStatusApi* | [**SyncStatusList**](docs/SyncStatusApi.md#syncstatuslist) | **GET** /sync-status | 
*TeamsApi* | [**TeamsList**](docs/TeamsApi.md#teamslist) | **GET** /teams | 
*TeamsApi* | [**TeamsRetrieve**](docs/TeamsApi.md#teamsretrieve) | **GET** /teams/{id} | 
*TimeOffApi* | [**TimeOffCreate**](docs/TimeOffApi.md#timeoffcreate) | **POST** /time-off | 
*TimeOffApi* | [**TimeOffList**](docs/TimeOffApi.md#timeofflist) | **GET** /time-off | 
*TimeOffApi* | [**TimeOffMetaPostRetrieve**](docs/TimeOffApi.md#timeoffmetapostretrieve) | **GET** /time-off/meta/post | 
*TimeOffApi* | [**TimeOffRetrieve**](docs/TimeOffApi.md#timeoffretrieve) | **GET** /time-off/{id} | 
*TimeOffBalancesApi* | [**TimeOffBalancesList**](docs/TimeOffBalancesApi.md#timeoffbalanceslist) | **GET** /time-off-balances | 
*TimeOffBalancesApi* | [**TimeOffBalancesRetrieve**](docs/TimeOffBalancesApi.md#timeoffbalancesretrieve) | **GET** /time-off-balances/{id} | 
*WebhookReceiversApi* | [**WebhookReceiversCreate**](docs/WebhookReceiversApi.md#webhookreceiverscreate) | **POST** /webhook-receivers | 
*WebhookReceiversApi* | [**WebhookReceiversList**](docs/WebhookReceiversApi.md#webhookreceiverslist) | **GET** /webhook-receivers | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountDetails](docs/AccountDetails.md)
 - [Model.AccountDetailsAndActions](docs/AccountDetailsAndActions.md)
 - [Model.AccountDetailsAndActionsIntegration](docs/AccountDetailsAndActionsIntegration.md)
 - [Model.AccountDetailsAndActionsStatusEnum](docs/AccountDetailsAndActionsStatusEnum.md)
 - [Model.AccountIntegration](docs/AccountIntegration.md)
 - [Model.AccountToken](docs/AccountToken.md)
 - [Model.AccountTypeEnum](docs/AccountTypeEnum.md)
 - [Model.AvailableActions](docs/AvailableActions.md)
 - [Model.BankInfo](docs/BankInfo.md)
 - [Model.Benefit](docs/Benefit.md)
 - [Model.CategoriesEnum](docs/CategoriesEnum.md)
 - [Model.CategoryEnum](docs/CategoryEnum.md)
 - [Model.CommonModelScopesBodyRequest](docs/CommonModelScopesBodyRequest.md)
 - [Model.Company](docs/Company.md)
 - [Model.ConditionSchema](docs/ConditionSchema.md)
 - [Model.ConditionTypeEnum](docs/ConditionTypeEnum.md)
 - [Model.CountryEnum](docs/CountryEnum.md)
 - [Model.DataPassthroughRequest](docs/DataPassthroughRequest.md)
 - [Model.DebugModeLog](docs/DebugModeLog.md)
 - [Model.DebugModelLogSummary](docs/DebugModelLogSummary.md)
 - [Model.Deduction](docs/Deduction.md)
 - [Model.Earning](docs/Earning.md)
 - [Model.EarningTypeEnum](docs/EarningTypeEnum.md)
 - [Model.Employee](docs/Employee.md)
 - [Model.EmployeeEndpointRequest](docs/EmployeeEndpointRequest.md)
 - [Model.EmployeePayrollRun](docs/EmployeePayrollRun.md)
 - [Model.EmployeeRequest](docs/EmployeeRequest.md)
 - [Model.EmployeeResponse](docs/EmployeeResponse.md)
 - [Model.Employment](docs/Employment.md)
 - [Model.EmploymentStatusEnum](docs/EmploymentStatusEnum.md)
 - [Model.EmploymentTypeEnum](docs/EmploymentTypeEnum.md)
 - [Model.EnabledActionsEnum](docs/EnabledActionsEnum.md)
 - [Model.EncodingEnum](docs/EncodingEnum.md)
 - [Model.EndUserDetailsRequest](docs/EndUserDetailsRequest.md)
 - [Model.ErrorValidationProblem](docs/ErrorValidationProblem.md)
 - [Model.EthnicityEnum](docs/EthnicityEnum.md)
 - [Model.FlsaStatusEnum](docs/FlsaStatusEnum.md)
 - [Model.GenderEnum](docs/GenderEnum.md)
 - [Model.GenerateRemoteKeyRequest](docs/GenerateRemoteKeyRequest.md)
 - [Model.Group](docs/Group.md)
 - [Model.GroupTypeEnum](docs/GroupTypeEnum.md)
 - [Model.IgnoreCommonModelRequest](docs/IgnoreCommonModelRequest.md)
 - [Model.Issue](docs/Issue.md)
 - [Model.IssueStatusEnum](docs/IssueStatusEnum.md)
 - [Model.LinkToken](docs/LinkToken.md)
 - [Model.LinkedAccountCondition](docs/LinkedAccountCondition.md)
 - [Model.LinkedAccountConditionRequest](docs/LinkedAccountConditionRequest.md)
 - [Model.LinkedAccountSelectiveSyncConfiguration](docs/LinkedAccountSelectiveSyncConfiguration.md)
 - [Model.LinkedAccountSelectiveSyncConfigurationListRequest](docs/LinkedAccountSelectiveSyncConfigurationListRequest.md)
 - [Model.LinkedAccountSelectiveSyncConfigurationRequest](docs/LinkedAccountSelectiveSyncConfigurationRequest.md)
 - [Model.LinkedAccountStatus](docs/LinkedAccountStatus.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationTypeEnum](docs/LocationTypeEnum.md)
 - [Model.MaritalStatusEnum](docs/MaritalStatusEnum.md)
 - [Model.MetaResponse](docs/MetaResponse.md)
 - [Model.MethodEnum](docs/MethodEnum.md)
 - [Model.ModelOperation](docs/ModelOperation.md)
 - [Model.MultipartFormFieldRequest](docs/MultipartFormFieldRequest.md)
 - [Model.OperatorSchema](docs/OperatorSchema.md)
 - [Model.PaginatedAccountDetailsAndActionsList](docs/PaginatedAccountDetailsAndActionsList.md)
 - [Model.PaginatedBankInfoList](docs/PaginatedBankInfoList.md)
 - [Model.PaginatedBenefitList](docs/PaginatedBenefitList.md)
 - [Model.PaginatedCompanyList](docs/PaginatedCompanyList.md)
 - [Model.PaginatedConditionSchemaList](docs/PaginatedConditionSchemaList.md)
 - [Model.PaginatedEmployeeList](docs/PaginatedEmployeeList.md)
 - [Model.PaginatedEmployeePayrollRunList](docs/PaginatedEmployeePayrollRunList.md)
 - [Model.PaginatedEmploymentList](docs/PaginatedEmploymentList.md)
 - [Model.PaginatedGroupList](docs/PaginatedGroupList.md)
 - [Model.PaginatedIssueList](docs/PaginatedIssueList.md)
 - [Model.PaginatedLocationList](docs/PaginatedLocationList.md)
 - [Model.PaginatedPayGroupList](docs/PaginatedPayGroupList.md)
 - [Model.PaginatedPayrollRunList](docs/PaginatedPayrollRunList.md)
 - [Model.PaginatedSyncStatusList](docs/PaginatedSyncStatusList.md)
 - [Model.PaginatedTeamList](docs/PaginatedTeamList.md)
 - [Model.PaginatedTimeOffBalanceList](docs/PaginatedTimeOffBalanceList.md)
 - [Model.PaginatedTimeOffList](docs/PaginatedTimeOffList.md)
 - [Model.PayCurrencyEnum](docs/PayCurrencyEnum.md)
 - [Model.PayFrequencyEnum](docs/PayFrequencyEnum.md)
 - [Model.PayGroup](docs/PayGroup.md)
 - [Model.PayPeriodEnum](docs/PayPeriodEnum.md)
 - [Model.PayrollRun](docs/PayrollRun.md)
 - [Model.PolicyTypeEnum](docs/PolicyTypeEnum.md)
 - [Model.ReasonEnum](docs/ReasonEnum.md)
 - [Model.RemoteData](docs/RemoteData.md)
 - [Model.RemoteKey](docs/RemoteKey.md)
 - [Model.RemoteKeyForRegenerationRequest](docs/RemoteKeyForRegenerationRequest.md)
 - [Model.RemoteResponse](docs/RemoteResponse.md)
 - [Model.RequestFormatEnum](docs/RequestFormatEnum.md)
 - [Model.RequestTypeEnum](docs/RequestTypeEnum.md)
 - [Model.ResponseTypeEnum](docs/ResponseTypeEnum.md)
 - [Model.RunStateEnum](docs/RunStateEnum.md)
 - [Model.RunTypeEnum](docs/RunTypeEnum.md)
 - [Model.SelectiveSyncConfigurationsUsageEnum](docs/SelectiveSyncConfigurationsUsageEnum.md)
 - [Model.SyncStatus](docs/SyncStatus.md)
 - [Model.SyncStatusStatusEnum](docs/SyncStatusStatusEnum.md)
 - [Model.Tax](docs/Tax.md)
 - [Model.Team](docs/Team.md)
 - [Model.TimeOff](docs/TimeOff.md)
 - [Model.TimeOffBalance](docs/TimeOffBalance.md)
 - [Model.TimeOffEndpointRequest](docs/TimeOffEndpointRequest.md)
 - [Model.TimeOffRequest](docs/TimeOffRequest.md)
 - [Model.TimeOffResponse](docs/TimeOffResponse.md)
 - [Model.TimeOffStatusEnum](docs/TimeOffStatusEnum.md)
 - [Model.UnitsEnum](docs/UnitsEnum.md)
 - [Model.ValidationProblemSource](docs/ValidationProblemSource.md)
 - [Model.WarningValidationProblem](docs/WarningValidationProblem.md)
 - [Model.WebhookReceiver](docs/WebhookReceiver.md)
 - [Model.WebhookReceiverRequest](docs/WebhookReceiverRequest.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="tokenAuth"></a>
### tokenAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

