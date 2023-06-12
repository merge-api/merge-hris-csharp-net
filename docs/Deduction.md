# Merge.HRISClient.Model.Deduction
# The Deduction Object ### Description The `Deduction` object is used to represent an array of the wages withheld from total earnings for the purpose of paying taxes.  ### Usage Example Fetch from the `LIST Deductions` endpoint and filter by `ID` to show all deductions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**EmployeePayrollRun** | **Guid?** |  | [optional] 
**Name** | **string** | The deduction&#39;s name. | [optional] 
**EmployeeDeduction** | **double?** | The amount of money that is withheld from an employee&#39;s gross pay by the employee. | [optional] 
**CompanyDeduction** | **double?** | The amount of money that is withheld on behalf of an employee by the company. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

