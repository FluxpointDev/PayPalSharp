




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
    /// </summary>

    public class Cost
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Cost() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The cost, as a percent value. Valid value is from 0 to 100.
        /// </summary>
        [JsonPropertyName("percent")]
        public double? Percent;
    }
}

