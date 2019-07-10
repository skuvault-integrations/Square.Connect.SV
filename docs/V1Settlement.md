# Square.Connect.Model.V1Settlement

### Description

V1Settlement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The settlement&#39;s unique identifier. | [optional] 
**Status** | **string** | The settlement&#39;s current status. See [V1SettlementStatus](#type-v1settlementstatus) for possible values | [optional] 
**TotalMoney** | [**V1Money**](V1Money.md) | The amount of money involved in the settlement. A positive amount indicates a deposit, and a negative amount indicates a withdrawal. This amount is never zero. | [optional] 
**InitiatedAt** | **string** | The time when the settlement was submitted for deposit or withdrawal, in ISO 8601 format. | [optional] 
**BankAccountId** | **string** | The Square-issued unique identifier for the bank account associated with the settlement. | [optional] 
**Entries** | [**List&lt;V1SettlementEntry&gt;**](V1SettlementEntry.md) | The entries included in this settlement. | [optional] 



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

