# Merge.HRISClient.Model.DataPassthroughRequest
# The DataPassthrough Object ### Description The `DataPassthrough` object is used to send information to an otherwise-unsupported third-party endpoint.  ### Usage Example Create a `DataPassthrough` to get team hierarchies from your Rippling integration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Method** | **MethodEnum** |  | 
**Path** | **string** |  | 
**BaseUrlOverride** | **string** |  | [optional] 
**Data** | **string** |  | [optional] 
**MultipartFormData** | [**List&lt;MultipartFormFieldRequest&gt;**](MultipartFormFieldRequest.md) | Pass an array of &#x60;MultipartFormField&#x60; objects in here instead of using the &#x60;data&#x60; param if &#x60;request_format&#x60; is set to &#x60;MULTIPART&#x60;. | [optional] 
**Headers** | **Dictionary&lt;string, Object&gt;** | The headers to use for the request (Merge will handle the account&#39;s authorization headers). &#x60;Content-Type&#x60; header is required for passthrough. Choose content type corresponding to expected format of receiving server. | [optional] 
**RequestFormat** | **RequestFormatEnum** |  | [optional] 
**NormalizeResponse** | **bool** | Optional. If true, the response will always be an object of the form &#x60;{\&quot;type\&quot;: T, \&quot;value\&quot;: ...}&#x60; where &#x60;T&#x60; will be one of &#x60;string, boolean, number, null, array, object&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

