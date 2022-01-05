# Merge.HRISClient.Model.Earning
# The Earning Object ### Description The `Earning` object is used to represent an earning for a given employee's payroll run. One run could include several earnings.  ### Usage Example Fetch from the `LIST Earnings` endpoint and filter by `ID` to show all earnings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**EmployeePayrollRun** | **Guid?** | The earning&#39;s employee payroll run. | [optional] 
**Amount** | **float?** | The amount earned. | [optional] 
**Type** | **string** |  | 
**RemoteData** | **List&lt;Dictionary&lt;string, Object&gt;&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

