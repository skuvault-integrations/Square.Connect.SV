# Square.Connect.Model.ShiftWorkday

### Description

A `Shift` search query filter parameter that sets a range of days that  a `Shift` must start or end in before passing the filter condition.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateRange** | [**DateRange**](DateRange.md) | Dates for fetching the shifts | [optional] 
**MatchShiftsBy** | **string** | The strategy on which the dates are applied. See [ShiftWorkdayMatcher](#type-shiftworkdaymatcher) for possible values | [optional] 
**DefaultTimezone** | **string** | Location-specific timezones convert workdays to datetime filters. Every location included in the query must have a timezone, or this field must be provided as a fallback. Format: the IANA timezone database identifier for the relevant timezone. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

