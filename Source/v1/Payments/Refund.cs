// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The details for a refund transaction.
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
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [JsonPropertyName("capture_id")]
        public string CaptureId;

        /// <summary>
        /// The date and time when the refund was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The refund description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The ID of the refund transaction.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// Your own invoice or tracking ID number. Value is a string of single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the payment on which this transaction is based.
        /// </summary>
        [JsonPropertyName("parent_payment")]
        public string ParentPayment;

        /// <summary>
        /// The reason that the transaction is being refunded.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason;

        /// <summary>
        /// The ID of the sale transaction being refunded.
        /// </summary>
        [JsonPropertyName("sale_id")]
        public string SaleId;

        /// <summary>
        /// The state of the refund.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

