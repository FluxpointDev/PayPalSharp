// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The sale transaction details.
    /// </summary>

    public class Sale
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Sale() { }

        /// <summary>
        /// REQUIRED
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The ID of the billing agreement. Used as reference to execute this transaction.
        /// </summary>
        [JsonPropertyName("billing_agreement_id")]
        public string BillingAgreementId;

        /// <summary>
        /// The date and time when the PayPal eCheck transaction is expected to clear, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("clearing_time")]
        public string ClearingTime;

        /// <summary>
        /// REQUIRED
        /// The date and time of the sale, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The exchange rate for this transaction. Returned only in cross-currency use cases where a merchant bills a buyer in a non-primary currency for that buyer.
        /// </summary>
        [JsonPropertyName("exchange_rate")]
        public string ExchangeRate;

        /// <summary>
        /// The Fraud Management Filter (FMF) details that are applied to the payment that result in an accept, deny, or pending action. Returned in a payment response only if the merchant has enabled FMF in the profile settings and one of the fraud filters was triggered based on those settings. For more information, see [Fraud Management Filters Summary](/docs/classic/fmf/integration-guide/FMFSummary/).
        /// </summary>
        [JsonPropertyName("fmf_details")]
        public FmfDetails FmfDetails;

        /// <summary>
        /// REQUIRED
        /// The ID of the sale transaction.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [JsonPropertyName("parent_payment")]
        public string ParentPayment;

        /// <summary>
        /// An array of reasons that PayPal holds the recipient fund. Set only if the payment hold status is `HELD`.
        /// </summary>
        [JsonPropertyName("payment_hold_reasons")]
        public List<PaymentHoldReason> PaymentHoldReasons;

        /// <summary>
        /// The recipient fund status. Returned only when the fund status is `held`.
        /// </summary>
        [JsonPropertyName("payment_hold_status")]
        public string PaymentHoldStatus;

        /// <summary>
        /// The transaction payment mode. Supported only for PayPal payments.
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode;

        /// <summary>
        /// The processor-provided response codes that describe the submitted payment. Supported only when the `payment_method` is `credit_card`.
        /// </summary>
        [JsonPropertyName("processor_response")]
        public ProcessorResponse ProcessorResponse;

        /// <summary>
        /// The merchant protection level in effect for the transaction. Supported only for PayPal payments.
        /// </summary>
        [JsonPropertyName("protection_eligibility")]
        public string ProtectionEligibility;

        /// <summary>
        /// The merchant protection type in effect for the transaction. Returned only when `protection_eligibility` is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only for PayPal payments.
        /// </summary>
        [JsonPropertyName("protection_eligibility_type")]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The ID of the transaction that corresponds to this sale transaction.
        /// </summary>
        [JsonPropertyName("purchase_unit_reference_id")]
        public string PurchaseUnitReferenceId;

        /// <summary>
        /// A reason code that describes why the transaction state is pending or reversed. Supported only for PayPal payments.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode;

        /// <summary>
        /// The receipt ID, which is a payment ID number that is returned for guest users to identify the payment.
        /// </summary>
        [JsonPropertyName("receipt_id")]
        public string ReceiptId;

        /// <summary>
        /// The currency and amount for a transaction.
        /// </summary>
        [JsonPropertyName("receivable_amount")]
        public Currency ReceivableAmount;

        /// <summary>
        /// REQUIRED
        /// The sale transaction state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// The currency and amount for a transaction.
        /// </summary>
        [JsonPropertyName("transaction_fee")]
        public Currency TransactionFee;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

