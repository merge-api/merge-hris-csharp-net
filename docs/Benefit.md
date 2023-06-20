# Merge.HRISClient.Model.Benefit
# The Benefit Object ### Description The `Benefit` object is used to represent a benefit that an employee has enrolled in.  ### Usage Example Fetch from the `LIST Benefits` endpoint and filter by `ID` to show all benefits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee on the plan. | [optional] 
**ProviderName** | **string** | The name of the benefit provider. | [optional] 
**BenefitPlanType** | **string** | The type of benefit plan | [optional] 
**EmployeeContribution** | **double?** | The employee&#39;s contribution. | [optional] 
**CompanyContribution** | **double?** | The company&#39;s contribution. | [optional] 
**StartDate** | **DateTime?** | The day and time the benefit started. | [optional] 
**EndDate** | **DateTime?** | The day and time the benefit ended. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

