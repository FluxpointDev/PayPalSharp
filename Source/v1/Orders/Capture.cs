




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// A capture transaction.
    /// </summary>

    public class Capture
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Capture() { }

        /// <summary>
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The ID of the capture transaction.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// A reason code that indicates the reason for the transaction state of `pending` or `reversed`.
        /// </summary>
        [JsonPropertyName("reason_code")]
        public string ReasonCode;

        /// <summary>
        /// The state of the capture transaction.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("transaction_fee")]
        public Currency TransactionFee;
    }
}

