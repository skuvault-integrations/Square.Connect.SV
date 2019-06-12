# Square.Connect.Model.OrderReturnServiceCharge

### Description

The service charge applied to the original order.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uid** | **string** | Unique ID that identifies the return service charge only within this order.  This field is read-only. | [optional] 
**SourceServiceChargeUid** | **string** | &#x60;uid&#x60; of the Service Charge from the Order which contains the original charge of this service charge, null for unlinked returns. | [optional] 
**Name** | **string** | The name of the service charge. | [optional] 
**CatalogObjectId** | **string** | The ID referencing the service charge [CatalogObject](#type-catalogobject) | [optional] 
**Percentage** | **string** | The percentage of the service charge, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%.  Exactly one of percentage or amount_money should be set. | [optional] 
**AmountMoney** | [**Money**](Money.md) | The amount of a non-percentage based service charge.  Exactly one of percentage or amount_money should be set. | [optional] 
**AppliedMoney** | [**Money**](Money.md) | The amount of money applied to the order by the service charge, as calculated by the server.  For fixed-amount service charges, &#x60;applied_money&#x60; is equal to &#x60;amount_money&#x60;.  For percentage-based service charges, &#x60;applied_money&#x60; is the money calculated using the percentage. The &#x60;applied_money&#x60; field will include any inclusive tax amounts as well.  This field is read-only. | [optional] 
**TotalMoney** | [**Money**](Money.md) | The total amount of money to collect for the service charge.  Note that &#x60;total_money&#x60; does not equal &#x60;applied_money&#x60; plus &#x60;total_tax_money&#x60; if an inclusive tax is applied to the service charge since the inclusive tax amount will be included in both &#x60;applied_money&#x60; and &#x60;total_tax_money&#x60;.  This field is read-only. | [optional] 
**TotalTaxMoney** | [**Money**](Money.md) | The total amount of tax money to collect for the service charge.  This field is read-only. | [optional] 
**CalculationPhase** | **CalculationPhaseEnum** | The calculation phase after which to apply the service charge.  This field is read-only. See [OrderServiceChargeCalculationPhase](#type-orderservicechargecalculationphase) for possible values | [optional] 
**Taxable** | **bool?** | Indicates whether the surcharge can be taxed. Service charges calculated in the &#x60;TOTAL_PHASE&#x60; cannot be marked as taxable. | [optional] 
**ReturnTaxes** | [**List&lt;OrderReturnTax&gt;**](OrderReturnTax.md) | The taxes which apply to the service charge. Return-level taxes apply by default to service charge calculated in the &#x60;SUBTOTAL_PHASE&#x60; if the service charge is marked as taxable. | [optional] 


## CalculationPhaseEnum

Name | Value
------------ | -------------
**SUBTOTALPHASE** | "SUBTOTAL_PHASE"
**TOTALPHASE** | "TOTAL_PHASE"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

