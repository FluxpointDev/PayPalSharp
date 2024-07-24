




using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// A refund transaction.
    /// </summary>

    public class Refund
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Refund() { }

        /// <summary>
        /// The payment amount, with details.
        /// </summary>
        [JsonPropertyName("amount")]
        public Amount Amount;

        /// <summary>
        /// The ID of the sale transaction to refund.
        /// </summary>
        [JsonPropertyName("capture_id")]
        public string CaptureId;

        /// <summary>
        /// The ID of the refund transaction. Maximum length is 17 characters.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the sale transaction to refund.
        /// </summary>
        [JsonPropertyName("sale_id")]
        public string SaleId;

        /// <summary>
        /// The status of the refund.
        /// </summary>
        [JsonPropertyName("status")]
        public RefundStatusType Status;
    }

    public enum RefundStatusType
    {
        [EnumMember(Value = "PENDING")]
        Pending,

        [EnumMember(Value = "COMPLETED")]
        Completed,

        [EnumMember(Value = "FAILED")]
        Failed,
    }
}

