




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// An execute order request.
    /// </summary>

    public class ExecuteOrder
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ExecuteOrder() { }

        /// <summary>
        /// REQUIRED
        /// Indicates whether to disburse money instantly or later.
        /// </summary>
        [JsonPropertyName("disbursement_mode")]
        public string DisbursementMode;

        /// <summary>
        /// The payer. The payer funds the payment.
        /// </summary>
        [JsonPropertyName("payer")]
        public Payer Payer;
    }
}

