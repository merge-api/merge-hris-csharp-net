# Merge.HRISClient.Model.EmploymentRequest
# The Employment Object ### Description The `Employment` object is used to represent an employment position at a company. These are associated with the employee filling the role.  ### Usage Example Fetch from the `LIST Employments` endpoint and filter by `ID` to show all employees.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**JobTitle** | **string** | The position&#39;s title. | [optional] 
**PayRate** | **float?** | The position&#39;s pay rate in dollars. | [optional] 
**PayPeriod** | **PayPeriodEnum** | The time period this pay rate encompasses. | [optional] 
**PayFrequency** | **PayFrequencyEnum** | The position&#39;s pay frequency. | [optional] 
**PayCurrency** | **PayCurrencyEnum** | The position&#39;s currency code. | [optional] 
**FlsaStatus** | **FlsaStatusEnum** | The position&#39;s FLSA status. | [optional] 
**EffectiveDate** | **DateTime?** | The position&#39;s effective date. | [optional] 
**EmploymentType** | **EmploymentTypeEnum** | The position&#39;s type of employment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

