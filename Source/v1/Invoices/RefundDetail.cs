




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Invoicing refund details.
    /// </summary>

    public class RefundDetail
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RefundDetail() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The date when the invoice was refunded. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6). For example, `2014-02-27 PST`.
        /// </summary>
        [JsonPropertyName("date")]
        public string Date;

        /// <summary>
        /// A note associated with the refund.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;

        /// <summary>
        /// The ID of the PayPal refund transaction. Required with the `PAYPAL` refund type.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The PayPal refund type. Indicates whether the refund was paid through PayPal or externally in invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

