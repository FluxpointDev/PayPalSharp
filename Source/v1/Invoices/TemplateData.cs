




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Template data.
    /// </summary>

    public class TemplateData
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateData() { }

        /// <summary>
        /// Indicates whether the invoice allows a partial payment. If `false`, invoice must be paid in full. If `true`, the invoice allows partial payments.
        /// </summary>
        [JsonPropertyName("allow_partial_payment")]
        public bool? AllowPartialPayment;

        /// <summary>
        /// List of files that are attached to the invoice.
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<FileAttachment> Attachments;

        /// <summary>
        /// The required invoice recipient email address and any optional billing information. Supports one recipient only.
        /// </summary>
        [JsonPropertyName("billing_info")]
        public List<BillingInfo> BillingInfo;

        /// <summary>
        /// For invoices sent by email, one or more email addresses to which to send a CC: copy of the notification. Supports only email addresses under participant.
        /// </summary>
        [JsonPropertyName("cc_info")]
        public List<string> CcInfo;

        /// <summary>
        /// The custom amount to apply to an invoice. If you include a label, you must include a custom amount.
        /// </summary>
        [JsonPropertyName("custom")]
        public CustomAmount Custom;

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [JsonPropertyName("discount")]
        public Cost Discount;

        /// <summary>
        /// The list of items to include in the invoice. Each invoice can contain up to 100 items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<InvoiceItem> Items;

        /// <summary>
        /// The full URL of an external logo image.
        /// </summary>
        [JsonPropertyName("logo_url")]
        public string LogoUrl;

        /// <summary>
        /// REQUIRED
        /// Merchant business information that appears on the invoice.
        /// </summary>
        [JsonPropertyName("merchant_info")]
        public MerchantInformation MerchantInfo;

        /// <summary>
        /// A private bookkeeping memo for the merchant.
        /// </summary>
        [JsonPropertyName("merchant_memo")]
        public string MerchantMemo;

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("minimum_amount_due")]
        public Currency MinimumAmountDue;

        /// <summary>
        /// A note to the payer.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;

        /// <summary>
        /// The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
        /// </summary>
        [JsonPropertyName("payment_term")]
        public PaymentTerm PaymentTerm;

        /// <summary>
        /// Reference data, such as PO number, to add to the invoice.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference;

        /// <summary>
        /// The shipping cost, as a percentage or amount value.
        /// </summary>
        [JsonPropertyName("shipping_cost")]
        public ShippingCost ShippingCost;

        /// <summary>
        /// The shipping information for the invoice recipient.
        /// </summary>
        [JsonPropertyName("shipping_info")]
        public ShippingInfo ShippingInfo;

        /// <summary>
        /// Indicates whether the invoice allows a partial payment. If `false`, invoice must be paid in full. If `true`, the invoice allows partial payments.
        /// </summary>
        [JsonPropertyName("tax_calculated_after_discount")]
        public bool? TaxCalculatedAfterDiscount;

        /// <summary>
        /// Indicates whether the unit price includes tax.
        /// </summary>
        [JsonPropertyName("tax_inclusive")]
        public bool? TaxInclusive;

        /// <summary>
        /// The general terms of the invoice.
        /// </summary>
        [JsonPropertyName("terms")]
        public string Terms;

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("total_amount")]
        public Currency TotalAmount;
    }
}

