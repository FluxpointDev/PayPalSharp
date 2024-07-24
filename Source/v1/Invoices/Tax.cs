




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Tax information.
    /// </summary>

    public class Tax
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Tax() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The resource ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The tax name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The tax rate. Valid value is from 0.001 to 99.999.
        /// </summary>
        [JsonPropertyName("percent")]
        public double? Percent;
    }
}

