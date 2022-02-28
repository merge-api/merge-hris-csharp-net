# Merge.HRISClient.Model.PayrollRun
# The PayrollRun Object ### Description The `PayrollRun` object is used to represent a payroll run.  ### Usage Example Fetch from the `LIST PayrollRuns` endpoint and filter by `ID` to show all payroll runs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RunState** | **RunStateEnum** | The state of the payroll run | [optional] 
**RunType** | **RunTypeEnum** | The type of the payroll run | [optional] 
**StartDate** | **DateTime?** | The day and time the payroll run started. | [optional] 
**EndDate** | **DateTime?** | The day and time the payroll run ended. | [optional] 
**CheckDate** | **DateTime?** | The day and time the payroll run was checked. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

