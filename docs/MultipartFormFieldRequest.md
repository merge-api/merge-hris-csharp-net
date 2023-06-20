# Merge.HRISClient.Model.MultipartFormFieldRequest
# The MultipartFormField Object ### Description The `MultipartFormField` object is used to represent fields in an HTTP request using `multipart/form-data`.  ### Usage Example Create a `MultipartFormField` to define a multipart form entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the form field | 
**Data** | **string** | The data for the form field. | 
**Encoding** | **EncodingEnum** | The encoding of the value of &#x60;data&#x60;. Defaults to &#x60;RAW&#x60; if not defined.  * &#x60;RAW&#x60; - RAW * &#x60;BASE64&#x60; - BASE64 * &#x60;GZIP_BASE64&#x60; - GZIP_BASE64 | [optional] 
**FileName** | **string** | The file name of the form field, if the field is for a file. | [optional] 
**ContentType** | **string** | The MIME type of the file, if the field is for a file. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

