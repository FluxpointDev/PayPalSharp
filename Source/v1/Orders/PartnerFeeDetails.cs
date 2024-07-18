




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The partner fee that is collected for the original transaction.
    /// </summary>

    public class PartnerFeeDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PartnerFeeDetails() { }

        /// <summary>
        /// REQUIRED
        /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// REQUIRED
        /// The payee who receives the funds and fulfills the order.
        /// </summary>
        [JsonPropertyName("receiver")]
        public Payee Receiver;
    }
}

