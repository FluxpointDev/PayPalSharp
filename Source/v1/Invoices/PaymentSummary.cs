




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The payment and refund summary.
    /// </summary>

    public class PaymentSummary
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentSummary() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("other")]
        public Currency Other;

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("paypal")]
        public Currency Paypal;
    }
}

