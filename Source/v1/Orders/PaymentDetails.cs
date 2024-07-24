




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payment details for the order.
    /// </summary>

    public class PaymentDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentDetails() { }

        /// <summary>
        /// Indicates whether to disburse money instantly or later.
        /// </summary>
        [JsonPropertyName("disbursement_mode")]
        public string DisbursementMode;

        /// <summary>
        /// The payment ID for the order.
        /// </summary>
        [JsonPropertyName("payment_id")]
        public string PaymentId;
    }
}

