# Merge.HRISClient.Model.Issue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**Status** | **IssueStatusEnum** | Status of the issue. Options: (&#39;ONGOING&#39;, &#39;RESOLVED&#39;)  * &#x60;ONGOING&#x60; - ONGOING * &#x60;RESOLVED&#x60; - RESOLVED | [optional] 
**ErrorDescription** | **string** |  | 
**EndUser** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**FirstIncidentTime** | **DateTime?** |  | [optional] 
**LastIncidentTime** | **DateTime?** |  | [optional] 
**IsMuted** | **bool** |  | [optional] [readonly] 
**ErrorDetails** | **List&lt;string&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

