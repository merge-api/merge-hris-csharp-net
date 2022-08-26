# Merge.HRISClient.Model.AccountDetailsAndActions
# The LinkedAccount Object ### Description The `LinkedAccount` object is used to represent an end user's link with a specific integration.  ### Usage Example View a list of your organization's `LinkedAccount` objects.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Category** | **CategoryEnum** |  | [optional] 
**Status** | **AccountDetailsAndActionsStatusEnum** |  | 
**StatusDetail** | **string** |  | [optional] 
**EndUserOriginId** | **string** |  | [optional] 
**EndUserOrganizationName** | **string** |  | 
**EndUserEmailAddress** | **string** |  | 
**WebhookListenerUrl** | **string** |  | 
**IsDuplicate** | **bool?** | Whether a Production Linked Account&#39;s credentials match another existing Production Linked Account. This field is &#x60;null&#x60; for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets. | [optional] 
**Integration** | [**AccountDetailsAndActionsIntegration**](AccountDetailsAndActionsIntegration.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

