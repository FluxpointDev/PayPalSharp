// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// An array of payments that the seller made.
    /// </summary>

    public class PaymentHistory
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentHistory() { }

        /// <summary>
        /// The number of items returned in each range of results. Note that the last results range might have fewer items than the requested number of items. The maximum value is `20`.
        /// </summary>
        [JsonPropertyName("count")]
        public int? Count;

        /// <summary>
        /// The ID of the next element. Use to get the next range of results.
        /// </summary>
        [JsonPropertyName("next_id")]
        public string NextId;

        /// <summary>
        /// An array of payments.
        /// </summary>
        [JsonPropertyName("payments")]
        public List<Payment> Payments;
    }
}

