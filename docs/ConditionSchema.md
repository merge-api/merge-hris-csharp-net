# Merge.HRISClient.Model.ConditionSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the condition schema. This ID is used when updating selective syncs for a linked account. | 
**CommonModel** | **string** | The common model for which a condition schema is defined. | [optional] [readonly] 
**NativeName** | **string** | User-facing *native condition* name. e.g. \&quot;Skip Manager\&quot;. | 
**FieldName** | **string** | The name of the field on the common model that this condition corresponds to, if they conceptually match. e.g. \&quot;location_type\&quot;. | 
**IsUnique** | **bool** | Whether this condition can only be applied once. If false, the condition can be AND&#39;d together multiple times. | [optional] 
**ConditionType** | **ConditionTypeEnum** | The type of value(s) that can be set for this condition.  * &#x60;BOOLEAN&#x60; - BOOLEAN * &#x60;DATE&#x60; - DATE * &#x60;DATE_TIME&#x60; - DATE_TIME * &#x60;INTEGER&#x60; - INTEGER * &#x60;FLOAT&#x60; - FLOAT * &#x60;STRING&#x60; - STRING * &#x60;LIST_OF_STRINGS&#x60; - LIST_OF_STRINGS | 
**Operators** | [**List&lt;OperatorSchema&gt;**](OperatorSchema.md) | The schemas for the operators that can be used on a condition. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

