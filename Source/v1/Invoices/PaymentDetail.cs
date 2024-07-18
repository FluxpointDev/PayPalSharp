




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Payment details.
    /// </summary>

    public class PaymentDetail
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDetail() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The date when the invoice was paid. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("date")]
        public string Date;

        /// <summary>
        /// REQUIRED
        /// The payment mode or method. Required with the `EXTERNAL` payment type.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method;

        /// <summary>
        /// Optional. A note associated with the payment.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;

        /// <summary>
        /// The ID for a PayPal payment transaction. Required with the `PAYPAL` payment type.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The transaction type.
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType;

        /// <summary>
        /// The payment type in an invoicing flow. The [record refund](/docs/api/invoicing/#invoices_record-refund) method supports the `EXTERNAL` refund type. The `PAYPAL` refund type is supported for backward compatibility.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

