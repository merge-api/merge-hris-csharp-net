# Merge.HRISClient.Model.TimeOffRequest
# The TimeOff Object ### Description The `TimeOff` object is used to represent all employees' Time Off entries.  ### Usage Example Fetch from the `LIST TimeOffs` endpoint and filter by `ID` to show all time off requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Employee** | **Guid?** | The employee requesting time off. | [optional] 
**Approver** | **Guid?** | The Merge ID of the employee with the ability to approve the time off request. | [optional] 
**Status** | **TimeOffStatusEnum** | The status of this time off request.  * &#x60;REQUESTED&#x60; - REQUESTED * &#x60;APPROVED&#x60; - APPROVED * &#x60;DECLINED&#x60; - DECLINED * &#x60;CANCELLED&#x60; - CANCELLED * &#x60;DELETED&#x60; - DELETED | [optional] 
**EmployeeNote** | **string** | The employee note for this time off request. | [optional] 
**Units** | **UnitsEnum** | The measurement that the third-party integration uses to count time requested.  * &#x60;HOURS&#x60; - HOURS * &#x60;DAYS&#x60; - DAYS | [optional] 
**Amount** | **double?** | The time off quantity measured by the prescribed “units”. | [optional] 
**RequestType** | **RequestTypeEnum** | The type of time off request.  * &#x60;VACATION&#x60; - VACATION * &#x60;SICK&#x60; - SICK * &#x60;PERSONAL&#x60; - PERSONAL * &#x60;JURY_DUTY&#x60; - JURY_DUTY * &#x60;VOLUNTEER&#x60; - VOLUNTEER * &#x60;BEREAVEMENT&#x60; - BEREAVEMENT | [optional] 
**StartTime** | **DateTime?** | The day and time of the start of the time requested off. | [optional] 
**EndTime** | **DateTime?** | The day and time of the end of the time requested off. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

