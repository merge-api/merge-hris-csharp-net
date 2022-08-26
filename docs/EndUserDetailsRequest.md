# Merge.HRISClient.Model.EndUserDetailsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndUserEmailAddress** | **string** | Your end user&#39;s email address. | 
**EndUserOrganizationName** | **string** | Your end user&#39;s organization. | 
**EndUserOriginId** | **string** | Unique ID for your end user. | 
**Categories** | [**List&lt;CategoriesEnum&gt;**](CategoriesEnum.md) | The integration categories to show in Merge Link. | 
**Integration** | **string** | The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://www.merge.dev/docs/basics/integration-metadata/. | [optional] 
**LinkExpiryMins** | **int** | An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30. | [optional] [default to 30]
**ShouldCreateMagicLinkUrl** | **bool?** | Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/product/integrations,-fast.-say-hello-to-magic-link/. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

