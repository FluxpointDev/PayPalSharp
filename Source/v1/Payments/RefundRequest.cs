// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// A refund request.
    /// </summary>

    public class RefundRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RefundRequest() { }

        /// <summary>
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The refund description. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The invoice number that is used to track this payment. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// The refund reason description.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason;
    }
}

