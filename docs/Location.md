# Merge.HRISClient.Model.Location
# The Location Object ### Description The `Location` object is used to represent a Location for a Company or Employee address. This is shared across many models and is referenced whenever a location is stored.  ### Usage Example Fetch from the `LIST Locations` endpoint and filter by `ID` to show all office locations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Name** | **string** | The location&#39;s name. | [optional] 
**PhoneNumber** | **string** | The location&#39;s phone number. | [optional] 
**Street1** | **string** | Line 1 of the location&#39;s street address. | [optional] 
**Street2** | **string** | Line 2 of the location&#39;s street address. | [optional] 
**City** | **string** | The location&#39;s city. | [optional] 
**State** | **string** | The location&#39;s state. Represents a region if outside of the US. | [optional] 
**ZipCode** | **string** | The location&#39;s zip code or postal code. | [optional] 
**Country** | **CountryEnum** | The location&#39;s country. | [optional] 
**LocationType** | **LocationTypeEnum** | The location&#39;s type. Can be either WORK or HOME | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

