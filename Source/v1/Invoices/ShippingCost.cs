




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The shipping cost, as a percentage or amount value.
    /// </summary>

    public class ShippingCost
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingCost() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// Tax information.
        /// </summary>
        [JsonPropertyName("tax")]
        public Tax Tax;
    }
}

