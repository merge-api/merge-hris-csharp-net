# Merge.HRISClient.Model.PayGroup
# The PayGroup Object ### Description The `PayGroup` object is used to represent Pay Group information that employees belong to. This is often referenced with an Employee object.  ### Usage Example Fetch from the `LIST PayGroup` endpoint and filter by `ID` to show all pay group information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**PayGroupName** | **string** | The pay group name. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

