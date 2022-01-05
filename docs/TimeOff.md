# Merge.HRISClient.Model.TimeOff
# The TimeOff Object ### Description The `TimeOff` object is used to represent a Time Off Request filed by an employee.  ### Usage Example Fetch from the `LIST TimeOffs` endpoint and filter by `ID` to show all time off requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee requesting time off. | [optional] 
**Approver** | **Guid?** | The employee approving the time off request. | [optional] 
**Status** | **string** |  | 
**EmployeeNote** | **string** | The employee note for this time off request. | [optional] 
**Units** | **string** |  | 
**Amount** | **float?** | The number of time off units requested. | [optional] 
**RequestType** | **string** |  | 
**StartTime** | **DateTime?** | The day and time of the start of the time requested off. | [optional] 
**EndTime** | **DateTime?** | The day and time of the end of the time requested off. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

