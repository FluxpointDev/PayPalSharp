// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The order transaction details.
    /// </summary>

    public class Order
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Order() { }

        /// <summary>
        /// REQUIRED
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The Fraud Management Filter (FMF) details that are applied to the payment that result in an accept, deny, or pending action. Returned in a payment response only if the merchant has enabled FMF in the profile settings and one of the fraud filters was triggered based on those settings. For more information, see [Fraud Management Filters Summary](/docs/classic/fmf/integration-guide/FMFSummary/).
        /// </summary>
        [JsonPropertyName("fmf_details")]
        public FmfDetails FmfDetails;

        /// <summary>
        /// The ID of the order transaction.
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
        /// The transaction payment mode.
        /// </summary>
        [JsonPropertyName("payment_mode")]
        public string PaymentMode;

        /// <summary>
        /// Deprecated. The reason code for the pending transaction state. Obsolete. Use `reason_code` instead.
        /// </summary>
        [JsonPropertyName("pending_reason")]
        public string PendingReason;

        /// <summary>
        /// The level of seller protection in effect for the transaction.
        /// </summary>
        [JsonPropertyName("protection_eligibility")]
        public string ProtectionEligibility;

        /// <summary>
        /// The kind of seller protection in effect for the transaction. Returned only when the `protection_eligibility` property is `ELIGIBLE` or `PARTIALLY_ELIGIBLE`. Supported only for PayPal payments. One or both of these values can be returned:<ul><li><code>ITEM_NOT_RECEIVED_ELIGIBLE</code>. Sellers are protected against claims for items not received.</li><li><code>UNAUTHORIZED_PAYMENT_ELIGIBLE</code>. Sellers are protected against claims for unauthorized payments.</li></ul>
        /// </summary>
        [JsonPropertyName("protection_eligibility_type")]
        public string ProtectionEligibilityType;

        /// <summary>
        /// The reason code that describes why the transaction state is pending or reversed. Eventually, this parameter will replace the `pending_reason` parameter. Supported only for PayPal payments.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode;

        /// <summary>
        /// The ID of the purchase unit that is associated with this object. Obsolete. Used only in `cart_base`.
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId;

        /// <summary>
        /// The order transaction state. Value is:<ul><li><code>pending</code>. The order was created but no authorizations/captures were made against the order.</li><li><code>authorized</code>. The order has only been authorized. No capture was made against the order.</li><li><code>captured</code>. The order has at least one capture initiated.</li><li><code>completed</code>. The order is complete as a capture was made against the order with <code>is_final_capture</code> set to <code>TRUE</code>. No more authorizations/captures can be made against this order.</li><li><code>voided</code>. The order was voided. No more authorizations/captures can be made against this order.</li></ul>
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

