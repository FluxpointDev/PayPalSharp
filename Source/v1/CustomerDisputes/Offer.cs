

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The information for the offer that a buyer or seller proposes for the dispute.
    /// </summary>

    public class Offer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Offer() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("buyer_requested_amount")]
        public Money BuyerRequestedAmount;
    }
}

