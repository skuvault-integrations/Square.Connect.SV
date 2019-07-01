# Square.Connect.Model.Customer

### Description

Represents one of a business's customers, which can have one or more cards on file associated with it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The customer&#39;s unique ID. | 
**CreatedAt** | **string** | The time when the customer was created, in RFC 3339 format. | 
**UpdatedAt** | **string** | The time when the customer was last updated, in RFC 3339 format. | 
**Cards** | [**List&lt;Card&gt;**](Card.md) | The payment details of the customer&#39;s cards on file. | [optional] 
**GivenName** | **string** | The customer&#39;s given (i.e., first) name. | [optional] 
**FamilyName** | **string** | The customer&#39;s family (i.e., last) name. | [optional] 
**Nickname** | **string** | The customer&#39;s nickname. | [optional] 
**CompanyName** | **string** | The name of the customer&#39;s company. | [optional] 
**EmailAddress** | **string** | The customer&#39;s email address. | [optional] 
**Address** | [**Address**](Address.md) | The customer&#39;s physical address. | [optional] 
**PhoneNumber** | **string** | The customer&#39;s phone number. | [optional] 
**Birthday** | **string** | The customer&#39;s birthday in RFC-3339 format. Year is optional, timezone and times are not allowed. Example: &#x60;0000-09-01T00:00:00-00:00&#x60; for a birthday on September 1st. &#x60;1998-09-01T00:00:00-00:00&#x60; for a birthday on September 1st 1998. | [optional] 
**ReferenceId** | **string** | A second ID you can set to associate the customer with an entity in another system. | [optional] 
**Note** | **string** | A note to associate with the customer. | [optional] 
**Preferences** | [**CustomerPreferences**](CustomerPreferences.md) | The customer&#39;s preferences. | [optional] 
**Groups** | [**List&lt;CustomerGroupInfo&gt;**](CustomerGroupInfo.md) | The groups the customer belongs to. | [optional] 
**CreationSource** | **string** | A creation source represents the method used to create the customer profile. See [CustomerCreationSource](#type-customercreationsource) for possible values | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

