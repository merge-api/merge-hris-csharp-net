# Merge.HRISClient.Model.EmployeePayrollRun
# The EmployeePayrollRun Object ### Description The `EmployeePayrollRun` object is used to represent an employee's pay statement for a specific payroll run.  ### Usage Example Fetch from the `LIST EmployeePayrollRun` endpoint and filter by `ID` to show all employee payroll runs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee whose payroll is being run. | [optional] 
**PayrollRun** | **Guid?** | The payroll being run. | [optional] 
**GrossPay** | **double?** | The total earnings throughout a given period for an employee before any deductions are made. | [optional] 
**NetPay** | **double?** | The take-home pay throughout a given period for an employee after deductions are made. | [optional] 
**StartDate** | **DateTime?** | The day and time the payroll run started. | [optional] 
**EndDate** | **DateTime?** | The day and time the payroll run ended. | [optional] 
**CheckDate** | **DateTime?** | The day and time the payroll run was checked. | [optional] 
**Earnings** | [**List&lt;Earning&gt;**](Earning.md) |  | [optional] [readonly] 
**Deductions** | [**List&lt;Deduction&gt;**](Deduction.md) |  | [optional] [readonly] 
**Taxes** | [**List&lt;Tax&gt;**](Tax.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

