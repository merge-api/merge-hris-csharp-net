# Merge.HRISClient.Model.BankInfo
# The BankInfo Object ### Description The `BankInfo` object is used to represent the Bank Account information for an Employee. This is often referenced with an Employee object.  ### Usage Example Fetch from the `LIST BankInfo` endpoint and filter by `ID` to show all bank information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Employee** | **Guid?** |  | [optional] 
**AccountNumber** | **string** | The account number. | [optional] 
**RoutingNumber** | **string** | The routing number. | [optional] 
**BankName** | **string** | The bank name. | [optional] 
**AccountType** | **AccountTypeEnum** | The bank account type | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the matching bank object was created in the third party system. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

