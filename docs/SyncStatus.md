# Merge.HRISClient.Model.SyncStatus
# The SyncStatus Object ### Description The `SyncStatus` object is used to represent the syncing state of an account  ### Usage Example View the `SyncStatus` for an account to see how recently its models were synced.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelName** | **string** |  | 
**ModelId** | **string** |  | 
**LastSyncStart** | **DateTime** |  | [optional] 
**NextSyncStart** | **DateTime** |  | [optional] 
**Status** | **SyncStatusStatusEnum** |  | 
**IsInitialSync** | **bool** |  | 
**SelectiveSyncConfigurationsUsage** | **SelectiveSyncConfigurationsUsageEnum** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

