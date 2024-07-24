




using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// A purchase unit. Establishes a contract between the payer and payee.
    /// </summary>

    public class PurchaseUnit
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PurchaseUnit() { }

        /// <summary>
        /// REQUIRED
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The client-provided external ID. Used to reconcile client transactions with PayPal transactions. Returned in transaction and settlement reports. Only supported for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("custom")]
        public string Custom;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The partner-provided external invoice number for this order. Only supported for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// An array of items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<Item> Items;

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Metadata Metadata;

        /// <summary>
        /// The payment notifications URL.
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl;

        /// <summary>
        /// The partner fee that is collected for the original transaction.
        /// </summary>
        [JsonPropertyName("partner_fee_details")]
        public PartnerFeeDetails PartnerFeeDetails;

        /// <summary>
        /// The payee who receives the funds and fulfills the order.
        /// </summary>
        [JsonPropertyName("payee")]
        public Payee Payee;

        /// <summary>
        /// The payment descriptor on the buyer credit card statement of account activity.
        /// </summary>
        [JsonPropertyName("payment_descriptor")]
        public string PaymentDescriptor;

        /// <summary>
        /// An ID that groups multiple linked purchase units. The purchase transactions are linked only for the payment and not for refund. A refund is processed only for the specific transaction within the same linked group.
        /// </summary>
        [JsonPropertyName("payment_linked_group")]
        public int? PaymentLinkedGroup;

        /// <summary>
        /// The payment summary.
        /// </summary>
        [JsonPropertyName("payment_summary")]
        public PaymentSummary PaymentSummary;

        /// <summary>
        /// The reason code for a transaction state of `pending` or `reversed`. Eventually, this field will replace `pending_reason`. Only supported for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode;

        /// <summary>
        /// REQUIRED
        /// The merchant ID for the purchase unit.
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId;

        /// <summary>
        /// The shipping address details.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress;

        /// <summary>
        /// The shipping method. For example, `USPSParcel`.
        /// </summary>
        [JsonPropertyName("shipping_method")]
        public string ShippingMethod;

        /// <summary>
        /// The transaction state.
        /// </summary>
        [JsonPropertyName("status")]
        public PurchaseUnitStatusType Status;
    }

    public enum PurchaseUnitStatusType
    {
        [EnumMember(Value = "NOT_PROCESSED")]
        NotProcessed,

        [EnumMember(Value = "PENDING")]
        Pending,

        [EnumMember(Value = "VOIDED")]
        Voided,

        [EnumMember(Value = "AUTHORIZED")]
        Authorized,

        [EnumMember(Value = "CAPTURED")]
        Captured,
    }
}

