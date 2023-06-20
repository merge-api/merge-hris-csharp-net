# Merge.HRISClient.Model.EndUserDetailsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EndUserEmailAddress** | **string** | Your end user&#39;s email address. This is purely for identification purposes - setting this value will not cause any emails to be sent. | 
**EndUserOrganizationName** | **string** | Your end user&#39;s organization. | 
**EndUserOriginId** | **string** | This unique identifier typically represents the ID for your end user in your product&#39;s database. This value must be distinct from other Linked Accounts&#39; unique identifiers. | 
**Categories** | [**List&lt;CategoriesEnum&gt;**](CategoriesEnum.md) | The integration categories to show in Merge Link. | 
**Integration** | **string** | The slug of a specific pre-selected integration for this linking flow token. For examples of slugs, see https://www.merge.dev/docs/basics/integration-metadata/. | [optional] 
**LinkExpiryMins** | **int** | An integer number of minutes between [30, 720 or 10080 if for a Magic Link URL] for how long this token is valid. Defaults to 30. | [optional] [default to 30]
**ShouldCreateMagicLinkUrl** | **bool?** | Whether to generate a Magic Link URL. Defaults to false. For more information on Magic Link, see https://merge.dev/blog/product/integrations,-fast.-say-hello-to-magic-link/. | [optional] [default to false]
**CommonModels** | [**List&lt;CommonModelScopesBodyRequest&gt;**](CommonModelScopesBodyRequest.md) | An array of objects to specify the models and fields that will be disabled for a given Linked Account. Each object uses model_id, enabled_actions, and disabled_fields to specify the model, method, and fields that are scoped for a given Linked Account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

