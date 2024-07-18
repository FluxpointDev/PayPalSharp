




using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// A pay order response.
    /// </summary>

    public class PayOrderResponse
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayOrderResponse() { }

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The intent.
        /// </summary>
        [JsonPropertyName("intent")]
        public string Intent;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId;

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInformation PayerInfo;

        /// <summary>
        /// An array of purchase units. Each unit establishes a contract between a payer and payee.
        /// </summary>
        [JsonPropertyName("purchase_units")]
        public List<PurchaseUnit> PurchaseUnits;

        /// <summary>
        /// The status of the order.
        /// </summary>
        [JsonPropertyName("status")]
        public PayOrderStatusType Status;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }

    public enum PayOrderStatusType
    {
        [EnumMember(Value = "CREATED")]
        Created,

        [EnumMember(Value = "APPROVED")]
        Approved,

        [EnumMember(Value = "CANCELED")]
        Canceled,

        [EnumMember(Value = "COMPLETED")]
        Completed,

        [EnumMember(Value = "EXPIRED")]
        Expired,

        [EnumMember(Value = "FAILED")]
        Failed,

        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        [EnumMember(Value = "PARTIALLY_COMPLETED")]
        PartiallyCompleted,

        [EnumMember(Value = "SUBMITTED")]
        Submitted,
    }
}

