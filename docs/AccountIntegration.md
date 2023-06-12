# Merge.HRISClient.Model.AccountIntegration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Company name. | 
**Categories** | [**List&lt;CategoriesEnum&gt;**](CategoriesEnum.md) | Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris]. | [optional] 
**Image** | **string** | Company logo in rectangular shape. &lt;b&gt;Upload an image with a clear background.&lt;/b&gt; | [optional] 
**SquareImage** | **string** | Company logo in square shape. &lt;b&gt;Upload an image with a white background.&lt;/b&gt; | [optional] 
**Color** | **string** | The color of this integration used for buttons and text throughout the app and landing pages. &lt;b&gt;Choose a darker, saturated color.&lt;/b&gt; | [optional] 
**Slug** | **string** |  | [optional] [readonly] 
**IsInBeta** | **bool** | If checked, this integration will not appear in the linking flow, and will appear elsewhere with a Beta tag. | [optional] 
**ApiEndpointsToDocumentationUrls** | **Dictionary&lt;string, Object&gt;** | Mapping of API endpoints to documentation urls for support. Example: {&#39;GET&#39;: [[&#39;/common-model-scopes&#39;, &#39;https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve&#39;],[&#39;/common-model-actions&#39;, &#39;https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve&#39;]], &#39;POST&#39;: []} | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

