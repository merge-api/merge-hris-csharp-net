# Merge.HRISClient.Model.TimeOffRequest
# The TimeOff Object ### Description The `TimeOff` object is used to represent a Time Off Request filed by an employee.  ### Usage Example Fetch from the `LIST TimeOffs` endpoint and filter by `ID` to show all time off requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** | The employee requesting time off. | [optional] 
**Approver** | **Guid?** | The employee approving the time off request. | [optional] 
**EmployeeNote** | **string** | The employee note for this time off request. | [optional] 
**Amount** | **float?** | The number of time off units requested. | [optional] 
**StartTime** | **DateTime?** | The day and time of the start of the time requested off. | [optional] 
**EndTime** | **DateTime?** | The day and time of the end of the time requested off. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

