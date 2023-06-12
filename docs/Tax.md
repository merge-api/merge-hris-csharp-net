# Merge.HRISClient.Model.Tax
# The Tax Object ### Description The `Tax` object is used to represent an array of the tax deductions for a given employee's payroll run.  ### Usage Example Fetch from the `LIST Taxes` endpoint and filter by `ID` to show all taxes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**EmployeePayrollRun** | **Guid?** |  | [optional] 
**Name** | **string** | The tax&#39;s name. | [optional] 
**Amount** | **double?** | The tax amount. | [optional] 
**EmployerTax** | **bool?** | Whether or not the employer is responsible for paying the tax. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

