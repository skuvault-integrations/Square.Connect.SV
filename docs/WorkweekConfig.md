# Square.Connect.Model.WorkweekConfig

### Description

Sets the Day of the week and hour of the day that a business starts a  work week. Used for the calculation of overtime pay.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | UUID for this object | [optional] 
**StartOfWeek** | **string** | The day of the week on which a business week cuts over for compensation purposes. See [Weekday](#type-weekday) for possible values | 
**StartOfDayLocalTime** | **string** | The local time at which a business week cuts over. Represented as a string in &#x60;HH:MM&#x60; format (&#x60;HH:MM:SS&#x60; is also accepted, but seconds are truncated). | 
**Version** | **int?** | Used for resolving concurrency issues; request will fail if version provided does not match server version at time of request. If not provided, Square executes a blind write; potentially overwriting data from another write. | [optional] 
**CreatedAt** | **string** | A read-only timestamp in RFC 3339 format; presented in UTC | [optional] 
**UpdatedAt** | **string** | A read-only timestamp in RFC 3339 format; presented in UTC | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

