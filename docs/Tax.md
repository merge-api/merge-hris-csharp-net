# Merge.HRISClient.Model.Tax
# The Tax Object ### Description The `Tax` object is used to represent a tax for a given employee's payroll run. One run could include several taxes.  ### Usage Example Fetch from the `LIST Taxes` endpoint and filter by `ID` to show all taxes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**EmployeePayrollRun** | **Guid?** |  | [optional] 
**Name** | **string** | The tax&#39;s name. | [optional] 
**Amount** | **float?** | The tax amount. | [optional] 
**EmployerTax** | **bool?** | Whether or not the employer is responsible for paying the tax. | [optional] 
**RemoteData** | **string** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

