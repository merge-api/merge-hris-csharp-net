# Merge.HRISClient.Model.Deduction
# The Deduction Object ### Description The `Deduction` object is used to represent a deduction for a given employee's payroll run. One run could include several deductions.  ### Usage Example Fetch from the `LIST Deductions` endpoint and filter by `ID` to show all deductions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**EmployeePayrollRun** | **Guid?** | The deduction&#39;s employee payroll run. | [optional] 
**Name** | **string** | The deduction&#39;s name. | [optional] 
**EmployeeDeduction** | **float?** | The amount the employee is deducting. | [optional] 
**CompanyDeduction** | **float?** | The amount the company is deducting. | [optional] 
**RemoteData** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

