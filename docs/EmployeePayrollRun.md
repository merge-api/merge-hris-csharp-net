# Merge.HRISClient.Model.EmployeePayrollRun
# The EmployeePayrollRun Object ### Description The `EmployeePayrollRun` object is used to represent a payroll run for a specific employee.  ### Usage Example Fetch from the `LIST EmployeePayrollRun` endpoint and filter by `ID` to show all employee payroll runs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee whose payroll is being run. | [optional] 
**PayrollRun** | **Guid?** | The payroll being run. | [optional] 
**GrossPay** | **float?** | The gross pay from the run. | [optional] 
**NetPay** | **float?** | The net pay from the run. | [optional] 
**StartDate** | **DateTime?** | The day and time the payroll run started. | [optional] 
**EndDate** | **DateTime?** | The day and time the payroll run ended. | [optional] 
**CheckDate** | **DateTime?** | The day and time the payroll run was checked. | [optional] 
**Earnings** | [**List&lt;Earning&gt;**](Earning.md) |  | [optional] [readonly] 
**Deductions** | [**List&lt;Deduction&gt;**](Deduction.md) |  | [optional] [readonly] 
**Taxes** | [**List&lt;Tax&gt;**](Tax.md) |  | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

