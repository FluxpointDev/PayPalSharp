// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The authorization details.
    /// </summary>

    public class Authorization
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Authorization() { }

        /// <summary>
        /// REQUIRED
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The date and time when the authorization was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The Fraud Management Filter (FMF) details that are applied to the payment that result in an accept, deny, or pending action. Returned in a payment response only if the merchant has enabled FMF in the profile settings and one of the fraud filters was triggered based on those settings. For more information, see [Fraud Management Filters Summary](/docs/classic/fmf/integration-guide/FMFSummary/).
        /// </summary>
        [JsonPropertyName("fmf_details")]
        public FmfDetails FmfDetails;

        /// <summary>
        /// The ID of the authorization.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [JsonPropertyName("parent_payment")]
        public string ParentPayment;

        /// <summary>
        /// The payment mode of the authorization.
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode;

        /// <summary>
        /// Deprecated. The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        /// </summary>
        [JsonPropertyName("pending_reason")]
        public string PendingReason;

        /// <summary>
        /// The processor-provided response codes that describe the submitted payment. Supported only when the `payment_method` is `credit_card`.
        /// </summary>
        [JsonPropertyName("processor_response")]
        public ProcessorResponse ProcessorResponse;

        /// <summary>
        /// The level of seller protection present for the transaction. Supported for the PayPal payment method only. Value is:<ul><li><code>ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Unauthorized Payments and Item Not Received.</li><li><code>PARTIALLY_ELIGIBLE</code>. Merchant is protected by PayPal's Seller Protection Policy for Item Not Received or Unauthorized Payments. For details, see `protection_eligibility_type`.</li><li><code>INELIGIBLE</code>. Merchant is not protected under the Seller Protection Policy.</li></ul>
        /// </summary>
        [JsonPropertyName("protection_eligibility")]
        public string ProtectionEligibility;

        /// <summary>
        /// The type of seller protection present for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported for the PayPal payment method only.<br/><br/>Returns one or both of the allowed values.<br/><br/>Value is:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        /// </summary>
        [JsonPropertyName("protection_eligibility_type")]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The reason code for the pending transaction state.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode;

        /// <summary>
        /// The receipt ID, which identifies the payment. Value is 16-digit numeric payment ID number that is returned for guest users.
        /// </summary>
        [JsonPropertyName("receipt_id")]
        public string ReceiptId;

        /// <summary>
        /// The ID of the purchase or transaction unit that corresponds to this authorization transaction.
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId;

        /// <summary>
        /// The authorization state.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// The date and time when the authorization was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTimeFormat;

        [JsonIgnore]
        public DateTime UpdateDate => DateTime.Parse(UpdateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The date and time when the authorization expires, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("valid_until")]
        public string ValidUntilFormat;

        [JsonIgnore]
        public DateTime ValidUntilDate => DateTime.Parse(ValidUntilFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

