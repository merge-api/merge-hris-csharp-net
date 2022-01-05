# Merge.HRISClient.Model.Benefit
# The Benefit Object ### Description The `Benefit` object is used to represent a Benefit for an employee.  ### Usage Example Fetch from the `LIST Benefits` endpoint and filter by `ID` to show all benefits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee on the plan. | [optional] 
**ProviderName** | **string** | The name of the benefit provider. | [optional] 
**BenefitPlanType** | **string** |  | 
**EmployeeContribution** | **float?** | The employee&#39;s contribution. | [optional] 
**CompanyContribution** | **float?** | The company&#39;s contribution. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

