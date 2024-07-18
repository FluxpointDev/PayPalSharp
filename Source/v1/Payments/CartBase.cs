// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The cart.
    /// </summary>

    public class CartBase
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CartBase() { }

        /// <summary>
        /// REQUIRED
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// A free-form field for the client's use.
        /// </summary>
        [JsonPropertyName("custom")]
        public string Custom;

        /// <summary>
        /// The purchase description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The invoice number to track this payment.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// An array of items that are being purchased.
        /// </summary>
        [JsonPropertyName("item_list")]
        public ItemList ItemList;

        /// <summary>
        /// Optional. A note to the recipient of the funds in this transaction.
        /// </summary>
        [JsonPropertyName("note_to_payee")]
        public string NoteToPayee;

        /// <summary>
        /// The URL to send payment notifications.
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl;

        /// <summary>
        /// The URL on the merchant site related to this payment.
        /// </summary>
        [JsonPropertyName("order_url")]
        public string OrderUrl;

        /// <summary>
        /// The payee who receives the funds and fulfills the order.
        /// </summary>
        [JsonPropertyName("payee")]
        public Payee Payee;

        /// <summary>
        /// The payment options for this transaction.
        /// </summary>
        [JsonPropertyName("payment_options")]
        public PaymentOptions PaymentOptions;

        /// <summary>
        /// The purchase order number or ID. Identifies this payment.
        /// </summary>
        [JsonPropertyName("purchase_order")]
        public string PurchaseOrder;

        /// <summary>
        /// Optional. The merchant-provided ID for the purchase unit.
        /// </summary>
        [JsonPropertyName("reference_id")]
        public string ReferenceId;

        /// <summary>
        /// The soft descriptor to use to charge this funding source. If the string's length is greater than the maximum allowed length, the API truncates the string.
        /// </summary>
        [JsonPropertyName("soft_descriptor")]
        public string SoftDescriptor;
    }
}

