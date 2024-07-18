




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The incentive details.
    /// </summary>

    public class IncentiveDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public IncentiveDetails() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("incentive_amount")]
        public Money IncentiveAmount;

        /// <summary>
        /// The code that identifies an incentive, such as a coupon.
        /// </summary>
        [JsonPropertyName("incentive_code")]
        public string IncentiveCode;

        /// <summary>
        /// The incentive program code that identifies a merchant loyalty or incentive program.
        /// </summary>
        [JsonPropertyName("incentive_program_code")]
        public string IncentiveProgramCode;

        /// <summary>
        /// The type of incentive, such as a special offer or coupon.
        /// </summary>
        [JsonPropertyName("incentive_type")]
        public string IncentiveType;
    }
}

