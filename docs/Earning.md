# Merge.HRISClient.Model.Earning
# The Earning Object ### Description The `Earning` object is used to represent an earning for a given employee's payroll run. One run could include several earnings.  ### Usage Example Fetch from the `LIST Earnings` endpoint and filter by `ID` to show all earnings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**EmployeePayrollRun** | **Guid?** |  | [optional] 
**Amount** | **float?** | The amount earned. | [optional] 
**Type** | **EarningTypeEnum** | The type of earning. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

