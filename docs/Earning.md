# Merge.HRISClient.Model.Earning
# The Earning Object ### Description The `Earning` object is used to represent an array of different compensations that an employee receives within specific wage categories.  ### Usage Example Fetch from the `LIST Earnings` endpoint and filter by `ID` to show all earnings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**EmployeePayrollRun** | **Guid?** |  | [optional] 
**Amount** | **double?** | The amount earned. | [optional] 
**Type** | **EarningTypeEnum** | The type of earning.  * &#x60;SALARY&#x60; - SALARY * &#x60;REIMBURSEMENT&#x60; - REIMBURSEMENT * &#x60;OVERTIME&#x60; - OVERTIME * &#x60;BONUS&#x60; - BONUS | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

