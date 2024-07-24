// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payment-related financial transactions, which include sales, authorizations, captures, and refunds. To show resource details, use the resource ID. For example, to [show details for a related authorization](/docs/api/payments/#authorization_get), use the ID returned in the `authorization` object. You can also use the [HATEOAS links](/docs/api/hateoas-links/) for a resource to complete operations for that resource. For example, a `sale` object provides a `refund` link that enables you to refund the sale.
    /// </summary>

    public class RelatedResources
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public RelatedResources() { }

        /// <summary>
        /// The authorization details.
        /// </summary>
        [JsonPropertyName("authorization")]
        public Authorization Authorization;

        /// <summary>
        /// The capture transaction details.
        /// </summary>
        [JsonPropertyName("capture")]
        public Capture Capture;

        /// <summary>
        /// The order transaction details.
        /// </summary>
        [JsonPropertyName("order")]
        public Order Order;

        /// <summary>
        /// The refund details.
        /// </summary>
        [JsonPropertyName("refund")]
        public Refund Refund;

        /// <summary>
        /// The sale transaction details.
        /// </summary>
        [JsonPropertyName("sale")]
        public Sale Sale;
    }
}

