# Merge.HRISClient.Model.Employment
# The Employment Object ### Description The `Employment` object is used to represent an employment position at a company. These are associated with the employee filling the role.  ### Usage Example Fetch from the `LIST Employments` endpoint and filter by `ID` to show all employees.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee holding this position. | [optional] 
**JobTitle** | **string** | The position&#39;s title. | [optional] 
**PayRate** | **float?** | The position&#39;s pay rate in dollars. | [optional] 
**PayPeriod** | **string** |  | 
**PayFrequency** | **string** |  | 
**PayCurrency** | **string** |  | 
**FlsaStatus** | **string** |  | 
**EffectiveDate** | **DateTime?** | The position&#39;s effective date. | [optional] 
**EmploymentType** | **string** |  | 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

