/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Square.Connect.Model
{
    /// <summary>
    /// Indicates specific errors that can occur during a request to the Connect API.
    /// </summary>
    /// <value>Indicates specific errors that can occur during a request to the Connect API.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorCode
    {
        
        /// <summary>
        /// Enum INTERNALSERVERERROR for "INTERNAL_SERVER_ERROR"
        /// </summary>
        [EnumMember(Value = "INTERNAL_SERVER_ERROR")]
        INTERNALSERVERERROR,
        
        /// <summary>
        /// Enum UNAUTHORIZED for "UNAUTHORIZED"
        /// </summary>
        [EnumMember(Value = "UNAUTHORIZED")]
        UNAUTHORIZED,
        
        /// <summary>
        /// Enum ACCESSTOKENEXPIRED for "ACCESS_TOKEN_EXPIRED"
        /// </summary>
        [EnumMember(Value = "ACCESS_TOKEN_EXPIRED")]
        ACCESSTOKENEXPIRED,
        
        /// <summary>
        /// Enum ACCESSTOKENREVOKED for "ACCESS_TOKEN_REVOKED"
        /// </summary>
        [EnumMember(Value = "ACCESS_TOKEN_REVOKED")]
        ACCESSTOKENREVOKED,
        
        /// <summary>
        /// Enum FORBIDDEN for "FORBIDDEN"
        /// </summary>
        [EnumMember(Value = "FORBIDDEN")]
        FORBIDDEN,
        
        /// <summary>
        /// Enum INSUFFICIENTSCOPES for "INSUFFICIENT_SCOPES"
        /// </summary>
        [EnumMember(Value = "INSUFFICIENT_SCOPES")]
        INSUFFICIENTSCOPES,
        
        /// <summary>
        /// Enum APPLICATIONDISABLED for "APPLICATION_DISABLED"
        /// </summary>
        [EnumMember(Value = "APPLICATION_DISABLED")]
        APPLICATIONDISABLED,
        
        /// <summary>
        /// Enum V1APPLICATION for "V1_APPLICATION"
        /// </summary>
        [EnumMember(Value = "V1_APPLICATION")]
        V1APPLICATION,
        
        /// <summary>
        /// Enum V1ACCESSTOKEN for "V1_ACCESS_TOKEN"
        /// </summary>
        [EnumMember(Value = "V1_ACCESS_TOKEN")]
        V1ACCESSTOKEN,
        
        /// <summary>
        /// Enum CARDPROCESSINGNOTENABLED for "CARD_PROCESSING_NOT_ENABLED"
        /// </summary>
        [EnumMember(Value = "CARD_PROCESSING_NOT_ENABLED")]
        CARDPROCESSINGNOTENABLED,
        
        /// <summary>
        /// Enum BADREQUEST for "BAD_REQUEST"
        /// </summary>
        [EnumMember(Value = "BAD_REQUEST")]
        BADREQUEST,
        
        /// <summary>
        /// Enum MISSINGREQUIREDPARAMETER for "MISSING_REQUIRED_PARAMETER"
        /// </summary>
        [EnumMember(Value = "MISSING_REQUIRED_PARAMETER")]
        MISSINGREQUIREDPARAMETER,
        
        /// <summary>
        /// Enum INCORRECTTYPE for "INCORRECT_TYPE"
        /// </summary>
        [EnumMember(Value = "INCORRECT_TYPE")]
        INCORRECTTYPE,
        
        /// <summary>
        /// Enum INVALIDTIME for "INVALID_TIME"
        /// </summary>
        [EnumMember(Value = "INVALID_TIME")]
        INVALIDTIME,
        
        /// <summary>
        /// Enum INVALIDTIMERANGE for "INVALID_TIME_RANGE"
        /// </summary>
        [EnumMember(Value = "INVALID_TIME_RANGE")]
        INVALIDTIMERANGE,
        
        /// <summary>
        /// Enum INVALIDVALUE for "INVALID_VALUE"
        /// </summary>
        [EnumMember(Value = "INVALID_VALUE")]
        INVALIDVALUE,
        
        /// <summary>
        /// Enum INVALIDCURSOR for "INVALID_CURSOR"
        /// </summary>
        [EnumMember(Value = "INVALID_CURSOR")]
        INVALIDCURSOR,
        
        /// <summary>
        /// Enum UNKNOWNQUERYPARAMETER for "UNKNOWN_QUERY_PARAMETER"
        /// </summary>
        [EnumMember(Value = "UNKNOWN_QUERY_PARAMETER")]
        UNKNOWNQUERYPARAMETER,
        
        /// <summary>
        /// Enum CONFLICTINGPARAMETERS for "CONFLICTING_PARAMETERS"
        /// </summary>
        [EnumMember(Value = "CONFLICTING_PARAMETERS")]
        CONFLICTINGPARAMETERS,
        
        /// <summary>
        /// Enum EXPECTEDJSONBODY for "EXPECTED_JSON_BODY"
        /// </summary>
        [EnumMember(Value = "EXPECTED_JSON_BODY")]
        EXPECTEDJSONBODY,
        
        /// <summary>
        /// Enum INVALIDSORTORDER for "INVALID_SORT_ORDER"
        /// </summary>
        [EnumMember(Value = "INVALID_SORT_ORDER")]
        INVALIDSORTORDER,
        
        /// <summary>
        /// Enum VALUEREGEXMISMATCH for "VALUE_REGEX_MISMATCH"
        /// </summary>
        [EnumMember(Value = "VALUE_REGEX_MISMATCH")]
        VALUEREGEXMISMATCH,
        
        /// <summary>
        /// Enum VALUETOOSHORT for "VALUE_TOO_SHORT"
        /// </summary>
        [EnumMember(Value = "VALUE_TOO_SHORT")]
        VALUETOOSHORT,
        
        /// <summary>
        /// Enum VALUETOOLONG for "VALUE_TOO_LONG"
        /// </summary>
        [EnumMember(Value = "VALUE_TOO_LONG")]
        VALUETOOLONG,
        
        /// <summary>
        /// Enum VALUETOOLOW for "VALUE_TOO_LOW"
        /// </summary>
        [EnumMember(Value = "VALUE_TOO_LOW")]
        VALUETOOLOW,
        
        /// <summary>
        /// Enum VALUETOOHIGH for "VALUE_TOO_HIGH"
        /// </summary>
        [EnumMember(Value = "VALUE_TOO_HIGH")]
        VALUETOOHIGH,
        
        /// <summary>
        /// Enum VALUEEMPTY for "VALUE_EMPTY"
        /// </summary>
        [EnumMember(Value = "VALUE_EMPTY")]
        VALUEEMPTY,
        
        /// <summary>
        /// Enum ARRAYLENGTHTOOLONG for "ARRAY_LENGTH_TOO_LONG"
        /// </summary>
        [EnumMember(Value = "ARRAY_LENGTH_TOO_LONG")]
        ARRAYLENGTHTOOLONG,
        
        /// <summary>
        /// Enum ARRAYLENGTHTOOSHORT for "ARRAY_LENGTH_TOO_SHORT"
        /// </summary>
        [EnumMember(Value = "ARRAY_LENGTH_TOO_SHORT")]
        ARRAYLENGTHTOOSHORT,
        
        /// <summary>
        /// Enum ARRAYEMPTY for "ARRAY_EMPTY"
        /// </summary>
        [EnumMember(Value = "ARRAY_EMPTY")]
        ARRAYEMPTY,
        
        /// <summary>
        /// Enum EXPECTEDBOOLEAN for "EXPECTED_BOOLEAN"
        /// </summary>
        [EnumMember(Value = "EXPECTED_BOOLEAN")]
        EXPECTEDBOOLEAN,
        
        /// <summary>
        /// Enum EXPECTEDINTEGER for "EXPECTED_INTEGER"
        /// </summary>
        [EnumMember(Value = "EXPECTED_INTEGER")]
        EXPECTEDINTEGER,
        
        /// <summary>
        /// Enum EXPECTEDFLOAT for "EXPECTED_FLOAT"
        /// </summary>
        [EnumMember(Value = "EXPECTED_FLOAT")]
        EXPECTEDFLOAT,
        
        /// <summary>
        /// Enum EXPECTEDSTRING for "EXPECTED_STRING"
        /// </summary>
        [EnumMember(Value = "EXPECTED_STRING")]
        EXPECTEDSTRING,
        
        /// <summary>
        /// Enum EXPECTEDOBJECT for "EXPECTED_OBJECT"
        /// </summary>
        [EnumMember(Value = "EXPECTED_OBJECT")]
        EXPECTEDOBJECT,
        
        /// <summary>
        /// Enum EXPECTEDARRAY for "EXPECTED_ARRAY"
        /// </summary>
        [EnumMember(Value = "EXPECTED_ARRAY")]
        EXPECTEDARRAY,
        
        /// <summary>
        /// Enum EXPECTEDBASE64ENCODEDBYTEARRAY for "EXPECTED_BASE64_ENCODED_BYTE_ARRAY"
        /// </summary>
        [EnumMember(Value = "EXPECTED_BASE64_ENCODED_BYTE_ARRAY")]
        EXPECTEDBASE64ENCODEDBYTEARRAY,
        
        /// <summary>
        /// Enum INVALIDARRAYVALUE for "INVALID_ARRAY_VALUE"
        /// </summary>
        [EnumMember(Value = "INVALID_ARRAY_VALUE")]
        INVALIDARRAYVALUE,
        
        /// <summary>
        /// Enum INVALIDENUMVALUE for "INVALID_ENUM_VALUE"
        /// </summary>
        [EnumMember(Value = "INVALID_ENUM_VALUE")]
        INVALIDENUMVALUE,
        
        /// <summary>
        /// Enum INVALIDCONTENTTYPE for "INVALID_CONTENT_TYPE"
        /// </summary>
        [EnumMember(Value = "INVALID_CONTENT_TYPE")]
        INVALIDCONTENTTYPE,
        
        /// <summary>
        /// Enum INVALIDFORMVALUE for "INVALID_FORM_VALUE"
        /// </summary>
        [EnumMember(Value = "INVALID_FORM_VALUE")]
        INVALIDFORMVALUE,
        
        /// <summary>
        /// Enum ONEINSTRUMENTEXPECTED for "ONE_INSTRUMENT_EXPECTED"
        /// </summary>
        [EnumMember(Value = "ONE_INSTRUMENT_EXPECTED")]
        ONEINSTRUMENTEXPECTED,
        
        /// <summary>
        /// Enum NOFIELDSSET for "NO_FIELDS_SET"
        /// </summary>
        [EnumMember(Value = "NO_FIELDS_SET")]
        NOFIELDSSET,
        
        /// <summary>
        /// Enum DEPRECATEDFIELDSET for "DEPRECATED_FIELD_SET"
        /// </summary>
        [EnumMember(Value = "DEPRECATED_FIELD_SET")]
        DEPRECATEDFIELDSET,
        
        /// <summary>
        /// Enum CARDEXPIRED for "CARD_EXPIRED"
        /// </summary>
        [EnumMember(Value = "CARD_EXPIRED")]
        CARDEXPIRED,
        
        /// <summary>
        /// Enum INVALIDEXPIRATION for "INVALID_EXPIRATION"
        /// </summary>
        [EnumMember(Value = "INVALID_EXPIRATION")]
        INVALIDEXPIRATION,
        
        /// <summary>
        /// Enum INVALIDEXPIRATIONYEAR for "INVALID_EXPIRATION_YEAR"
        /// </summary>
        [EnumMember(Value = "INVALID_EXPIRATION_YEAR")]
        INVALIDEXPIRATIONYEAR,
        
        /// <summary>
        /// Enum INVALIDEXPIRATIONDATE for "INVALID_EXPIRATION_DATE"
        /// </summary>
        [EnumMember(Value = "INVALID_EXPIRATION_DATE")]
        INVALIDEXPIRATIONDATE,
        
        /// <summary>
        /// Enum UNSUPPORTEDCARDBRAND for "UNSUPPORTED_CARD_BRAND"
        /// </summary>
        [EnumMember(Value = "UNSUPPORTED_CARD_BRAND")]
        UNSUPPORTEDCARDBRAND,
        
        /// <summary>
        /// Enum UNSUPPORTEDENTRYMETHOD for "UNSUPPORTED_ENTRY_METHOD"
        /// </summary>
        [EnumMember(Value = "UNSUPPORTED_ENTRY_METHOD")]
        UNSUPPORTEDENTRYMETHOD,
        
        /// <summary>
        /// Enum INVALIDCARD for "INVALID_CARD"
        /// </summary>
        [EnumMember(Value = "INVALID_CARD")]
        INVALIDCARD,
        
        /// <summary>
        /// Enum DELAYEDTRANSACTIONEXPIRED for "DELAYED_TRANSACTION_EXPIRED"
        /// </summary>
        [EnumMember(Value = "DELAYED_TRANSACTION_EXPIRED")]
        DELAYEDTRANSACTIONEXPIRED,
        
        /// <summary>
        /// Enum DELAYEDTRANSACTIONCANCELED for "DELAYED_TRANSACTION_CANCELED"
        /// </summary>
        [EnumMember(Value = "DELAYED_TRANSACTION_CANCELED")]
        DELAYEDTRANSACTIONCANCELED,
        
        /// <summary>
        /// Enum DELAYEDTRANSACTIONCAPTURED for "DELAYED_TRANSACTION_CAPTURED"
        /// </summary>
        [EnumMember(Value = "DELAYED_TRANSACTION_CAPTURED")]
        DELAYEDTRANSACTIONCAPTURED,
        
        /// <summary>
        /// Enum DELAYEDTRANSACTIONFAILED for "DELAYED_TRANSACTION_FAILED"
        /// </summary>
        [EnumMember(Value = "DELAYED_TRANSACTION_FAILED")]
        DELAYEDTRANSACTIONFAILED,
        
        /// <summary>
        /// Enum CARDTOKENEXPIRED for "CARD_TOKEN_EXPIRED"
        /// </summary>
        [EnumMember(Value = "CARD_TOKEN_EXPIRED")]
        CARDTOKENEXPIRED,
        
        /// <summary>
        /// Enum CARDTOKENUSED for "CARD_TOKEN_USED"
        /// </summary>
        [EnumMember(Value = "CARD_TOKEN_USED")]
        CARDTOKENUSED,
        
        /// <summary>
        /// Enum AMOUNTTOOHIGH for "AMOUNT_TOO_HIGH"
        /// </summary>
        [EnumMember(Value = "AMOUNT_TOO_HIGH")]
        AMOUNTTOOHIGH,
        
        /// <summary>
        /// Enum UNSUPPORTEDINSTRUMENTTYPE for "UNSUPPORTED_INSTRUMENT_TYPE"
        /// </summary>
        [EnumMember(Value = "UNSUPPORTED_INSTRUMENT_TYPE")]
        UNSUPPORTEDINSTRUMENTTYPE,
        
        /// <summary>
        /// Enum REFUNDAMOUNTINVALID for "REFUND_AMOUNT_INVALID"
        /// </summary>
        [EnumMember(Value = "REFUND_AMOUNT_INVALID")]
        REFUNDAMOUNTINVALID,
        
        /// <summary>
        /// Enum REFUNDALREADYPENDING for "REFUND_ALREADY_PENDING"
        /// </summary>
        [EnumMember(Value = "REFUND_ALREADY_PENDING")]
        REFUNDALREADYPENDING,
        
        /// <summary>
        /// Enum PAYMENTNOTREFUNDABLE for "PAYMENT_NOT_REFUNDABLE"
        /// </summary>
        [EnumMember(Value = "PAYMENT_NOT_REFUNDABLE")]
        PAYMENTNOTREFUNDABLE,
        
        /// <summary>
        /// Enum INVALIDCARDDATA for "INVALID_CARD_DATA"
        /// </summary>
        [EnumMember(Value = "INVALID_CARD_DATA")]
        INVALIDCARDDATA,
        
        /// <summary>
        /// Enum LOCATIONMISMATCH for "LOCATION_MISMATCH"
        /// </summary>
        [EnumMember(Value = "LOCATION_MISMATCH")]
        LOCATIONMISMATCH,
        
        /// <summary>
        /// Enum IDEMPOTENCYKEYREUSED for "IDEMPOTENCY_KEY_REUSED"
        /// </summary>
        [EnumMember(Value = "IDEMPOTENCY_KEY_REUSED")]
        IDEMPOTENCYKEYREUSED,
        
        /// <summary>
        /// Enum UNEXPECTEDVALUE for "UNEXPECTED_VALUE"
        /// </summary>
        [EnumMember(Value = "UNEXPECTED_VALUE")]
        UNEXPECTEDVALUE,
        
        /// <summary>
        /// Enum SANDBOXNOTSUPPORTED for "SANDBOX_NOT_SUPPORTED"
        /// </summary>
        [EnumMember(Value = "SANDBOX_NOT_SUPPORTED")]
        SANDBOXNOTSUPPORTED,
        
        /// <summary>
        /// Enum INVALIDEMAILADDRESS for "INVALID_EMAIL_ADDRESS"
        /// </summary>
        [EnumMember(Value = "INVALID_EMAIL_ADDRESS")]
        INVALIDEMAILADDRESS,
        
        /// <summary>
        /// Enum INVALIDPHONENUMBER for "INVALID_PHONE_NUMBER"
        /// </summary>
        [EnumMember(Value = "INVALID_PHONE_NUMBER")]
        INVALIDPHONENUMBER,
        
        /// <summary>
        /// Enum CHECKOUTEXPIRED for "CHECKOUT_EXPIRED"
        /// </summary>
        [EnumMember(Value = "CHECKOUT_EXPIRED")]
        CHECKOUTEXPIRED,
        
        /// <summary>
        /// Enum CARDDECLINED for "CARD_DECLINED"
        /// </summary>
        [EnumMember(Value = "CARD_DECLINED")]
        CARDDECLINED,
        
        /// <summary>
        /// Enum VERIFYCVVFAILURE for "VERIFY_CVV_FAILURE"
        /// </summary>
        [EnumMember(Value = "VERIFY_CVV_FAILURE")]
        VERIFYCVVFAILURE,
        
        /// <summary>
        /// Enum VERIFYAVSFAILURE for "VERIFY_AVS_FAILURE"
        /// </summary>
        [EnumMember(Value = "VERIFY_AVS_FAILURE")]
        VERIFYAVSFAILURE,
        
        /// <summary>
        /// Enum CARDDECLINEDCALLISSUER for "CARD_DECLINED_CALL_ISSUER"
        /// </summary>
        [EnumMember(Value = "CARD_DECLINED_CALL_ISSUER")]
        CARDDECLINEDCALLISSUER,
        
        /// <summary>
        /// Enum NOTFOUND for "NOT_FOUND"
        /// </summary>
        [EnumMember(Value = "NOT_FOUND")]
        NOTFOUND,
        
        /// <summary>
        /// Enum METHODNOTALLOWED for "METHOD_NOT_ALLOWED"
        /// </summary>
        [EnumMember(Value = "METHOD_NOT_ALLOWED")]
        METHODNOTALLOWED,
        
        /// <summary>
        /// Enum REQUESTTIMEOUT for "REQUEST_TIMEOUT"
        /// </summary>
        [EnumMember(Value = "REQUEST_TIMEOUT")]
        REQUESTTIMEOUT,
        
        /// <summary>
        /// Enum CONFLICT for "CONFLICT"
        /// </summary>
        [EnumMember(Value = "CONFLICT")]
        CONFLICT,
        
        /// <summary>
        /// Enum REQUESTENTITYTOOLARGE for "REQUEST_ENTITY_TOO_LARGE"
        /// </summary>
        [EnumMember(Value = "REQUEST_ENTITY_TOO_LARGE")]
        REQUESTENTITYTOOLARGE,
        
        /// <summary>
        /// Enum UNSUPPORTEDMEDIATYPE for "UNSUPPORTED_MEDIA_TYPE"
        /// </summary>
        [EnumMember(Value = "UNSUPPORTED_MEDIA_TYPE")]
        UNSUPPORTEDMEDIATYPE,
        
        /// <summary>
        /// Enum RATELIMITED for "RATE_LIMITED"
        /// </summary>
        [EnumMember(Value = "RATE_LIMITED")]
        RATELIMITED,
        
        /// <summary>
        /// Enum NOTIMPLEMENTED for "NOT_IMPLEMENTED"
        /// </summary>
        [EnumMember(Value = "NOT_IMPLEMENTED")]
        NOTIMPLEMENTED,
        
        /// <summary>
        /// Enum SERVICEUNAVAILABLE for "SERVICE_UNAVAILABLE"
        /// </summary>
        [EnumMember(Value = "SERVICE_UNAVAILABLE")]
        SERVICEUNAVAILABLE,
        
        /// <summary>
        /// Enum GATEWAYTIMEOUT for "GATEWAY_TIMEOUT"
        /// </summary>
        [EnumMember(Value = "GATEWAY_TIMEOUT")]
        GATEWAYTIMEOUT
    }

}
