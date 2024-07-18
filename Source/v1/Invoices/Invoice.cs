




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Invoice details.
    /// </summary>

    public class Invoice
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Invoice() { }

        /// <summary>
        /// Indicates whether the invoice allows a partial payment. If `false`, invoice must be paid in full. If `true`, the invoice allows partial payments.
        /// </summary>
        [JsonPropertyName("allow_partial_payment")]
        public bool? AllowPartialPayment;

        /// <summary>
        /// Indicates whether the invoice enables the customer to enter a tip amount during payment. If `true`, the invoice shows a tip amount field so that the customer can enter a tip amount. If `false`, the invoice does not show a tip amount field.
        /// </summary>
        [JsonPropertyName("allow_tip")]
        public bool? AllowTip;

        /// <summary>
        /// List of files that are attached to the invoice.
        /// </summary>
        [JsonPropertyName("attachments")]
        public List<FileAttachment> Attachments;

        /// <summary>
        /// The required invoice recipient email address and any optional billing information. Supports only one recipient.
        /// </summary>
        [JsonPropertyName("billing_info")]
        public List<BillingInfo> BillingInfo;

        /// <summary>
        /// For invoices sent by email, one or more email addresses to which to send a CC: copy of the notification. Supports only email addresses under participant.
        /// </summary>
        [JsonPropertyName("cc_info")]
        public List<Participant> CcInfo;

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
        /// The ID of the invoice.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// The date when the invoice was enabled. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate;

        /// <summary>
        /// The items to include in the invoice. An invoice can contain a maximum of 100 items.
        /// </summary>
        [JsonPropertyName("items")]
        public List<InvoiceItem> Items;

        /// <summary>
        /// The HATEOAS links that provide related actions for the invoice based on the current invoice status.
        /// </summary>
        [JsonPropertyName("links")]
        public List<InvoiceLinkDescriptionObject> Links;

        /// <summary>
        /// The full URL to an external logo image.
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
        /// Audit information for the resource.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Metadata Metadata;

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
        /// The unique invoice number. If you omit this number, it is auto-incremented from the previous invoice number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [JsonPropertyName("paid_amount")]
        public PaymentSummary PaidAmount;

        /// <summary>
        /// The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
        /// </summary>
        [JsonPropertyName("payment_term")]
        public PaymentTerm PaymentTerm;

        /// <summary>
        /// List of payment details for the invoice.
        /// </summary>
        [JsonPropertyName("payments")]
        public List<PaymentDetail> Payments;

        /// <summary>
        /// Reference data, such as PO number, to add to the invoice.
        /// </summary>
        [JsonPropertyName("reference")]
        public string Reference;

        /// <summary>
        /// The payment and refund summary.
        /// </summary>
        [JsonPropertyName("refunded_amount")]
        public PaymentSummary RefundedAmount;

        /// <summary>
        /// List of refund details for the invoice.
        /// </summary>
        [JsonPropertyName("refunds")]
        public List<RefundDetail> Refunds;

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
        /// The invoice status. When you [search for invoices](/docs/api/invoicing/#invoices_search), you must specify this value as an array. For example, `"status": ["REFUNDED"]`.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// Indicates whether the tax is calculated before or after a discount. If `false`, the tax is calculated before a discount. If `true`, the tax is calculated after a discount.
        /// </summary>
        [JsonPropertyName("tax_calculated_after_discount")]
        public bool? TaxCalculatedAfterDiscount;

        /// <summary>
        /// Indicates whether the unit price includes tax.
        /// </summary>
        [JsonPropertyName("tax_inclusive")]
        public bool? TaxInclusive;

        /// <summary>
        /// The ID of the template from which to create the invoice. Useful for copy functionality.
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId;

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

        /// <summary>
        /// The URI of the invoice.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri;
    }
}

