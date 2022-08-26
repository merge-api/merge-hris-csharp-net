# Merge.HRISClient.Model.AccountDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Integration** | **string** |  | [optional] [readonly] 
**IntegrationSlug** | **string** |  | [optional] [readonly] 
**Category** | **CategoryEnum** |  | [optional] 
**EndUserOriginId** | **string** |  | [optional] [readonly] 
**EndUserOrganizationName** | **string** |  | [optional] [readonly] 
**EndUserEmailAddress** | **string** |  | [optional] [readonly] 
**Status** | **string** |  | [optional] [readonly] 
**WebhookListenerUrl** | **string** |  | [optional] [readonly] 
**IsDuplicate** | **bool?** | Whether a Production Linked Account&#39;s credentials match another existing Production Linked Account. This field is &#x60;null&#x60; for Test Linked Accounts, incomplete Production Linked Accounts, and ignored duplicate Production Linked Account sets. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

