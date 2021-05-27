# Merge.HRISClient.Model.Company
# The Company Object ### Description The `Company` object is used to represent a Company.  ### Usage Example Fetch from the `LIST Companies` endpoint and filter by `ID` to show all companies.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**LegalName** | **string** | The company&#39;s legal name. | [optional] 
**DisplayName** | **string** | The company&#39;s display name. | [optional] 
**Eins** | **List&lt;string&gt;** | The company&#39;s Employer Identification Numbers. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

