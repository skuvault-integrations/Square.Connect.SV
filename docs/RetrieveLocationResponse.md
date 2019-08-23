# Square.Connect.Model.RetrieveLocationResponse

### Description

Defines the fields that are included in the response body of a request to the [RetrieveLocation](#endpoint-retrievelocation) endpoint.  One of `errors` or `location` is present in a given response (never both).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | [**List&lt;Error&gt;**](Error.md) | Any errors that occurred during the request. | [optional] 
**Location** | [**Location**](Location.md) | The requested location. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
