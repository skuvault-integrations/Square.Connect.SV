# Square.Connect.Model.BatchRetrieveInventoryChangesRequest

### Description



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CatalogObjectIds** | **List<string>** | Filters results by [CatalogObject](#type-catalogobject) ID. Only applied when set. Default: unset. | [optional] 
**LocationIds** | **List<string>** | Filters results by [Location](#type-location) ID. Only applied when set. Default: unset. | [optional] 
**Types** | **List<string>** | Filters results by [InventoryChangeType](#type-inventorychangetype). Default: [&#x60;PHYSICAL_COUNT&#x60;, &#x60;ADJUSTMENT&#x60;]. &#x60;TRANSFER&#x60; is not supported as a filter. See [InventoryChangeType](#type-inventorychangetype) for possible values | [optional] 
**States** | **List<string>** | Filters &#x60;ADJUSTMENT&#x60; query results by [InventoryState](#type-inventorystate). Only applied when set. Default: unset. See [InventoryState](#type-inventorystate) for possible values | [optional] 
**UpdatedAfter** | **string** | Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is after the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;). | [optional] 
**UpdatedBefore** | **string** | Provided as an RFC 3339 timestamp. Returns results whose &#x60;created_at&#x60; or &#x60;calculated_at&#x60; value is strictly before the given time. Default: UNIX epoch (&#x60;1970-01-01T00:00:00Z&#x60;). | [optional] 
**Cursor** | **string** | A pagination cursor returned by a previous call to this endpoint. Provide this to retrieve the next set of results for the original query.  See [Pagination](/basics/api101/pagination) for more information. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

