




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// An order.
    /// </summary>

    public class Order
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Order() { }

        /// <summary>
        /// The application context experience information.
        /// </summary>
        [JsonPropertyName("application_context")]
        public ApplicationContext ApplicationContext;

        /// <summary>
        /// The date and time when the resource was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// The intent.
        /// </summary>
        [JsonPropertyName("intent")]
        public string Intent;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links). To complete the buyer approval, use the `approval_url` link with the `GET` method and do not use the link that shows the `REDIRECT` method.
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// Metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public Metadata Metadata;

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInformation PayerInfo;

        /// <summary>
        /// The payment details for the order.
        /// </summary>
        [JsonPropertyName("payment_details")]
        public PaymentDetails PaymentDetails;

        /// <summary>
        /// REQUIRED
        /// An array of purchase units. Each purchase unit establishes a contract between the payer and payee.
        /// </summary>
        [JsonPropertyName("purchase_units")]
        public List<PurchaseUnit> PurchaseUnits;

        /// <summary>
        /// REQUIRED
        /// The redirect URLs. Required only for the PayPal payment method. The supported settings are return and cancel URLs.
        /// </summary>
        [JsonPropertyName("redirect_urls")]
        public RedirectUrls RedirectUrls;

        /// <summary>
        /// The status of the order. After the customer approves the order, the status is `APPROVED`. After the payment is made for the order and the order completes, the status is `COMPLETED`.
        /// </summary>
        [JsonPropertyName("status")]
        public OrderStatusType Status;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTimeFormat;

        [JsonIgnore]
        public DateTime UpdateDate => DateTime.Parse(UpdateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }

    public enum OrderStatusType
    {
        [EnumMember(Value = "CREATED")]
        Created,

        [EnumMember(Value = "APPROVED")]
        Approved,

        [EnumMember(Value = "COMPLETED")]
        Completed,

        [EnumMember(Value = "FAILED")]
        Failed,
    }
}

