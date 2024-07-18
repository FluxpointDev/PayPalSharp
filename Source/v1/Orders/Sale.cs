




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// A sale transaction.
    /// </summary>

    public class Sale
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Sale() { }

        /// <summary>
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The ID of the sale transaction.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The status of the sale transaction.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// The base currency object for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("transaction_fee")]
        public Currency TransactionFee;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

