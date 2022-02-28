# Merge.HRISClient.Model.Group
# The PayGroup Object ### Description The `PayGroup` object is used to represent Group information that employees belong to. This is often referenced with an Employee object.  ### Usage Example Fetch from the `LIST Employee` endpoint and expand groups to view an employees groups.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**ParentGroup** | **Guid?** | The parent group for this group. | [optional] 
**Name** | **string** | The group name. | [optional] 
**Type** | **GroupTypeEnum** | The group type | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

