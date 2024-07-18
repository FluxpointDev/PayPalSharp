// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f

// @data 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
using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The refund transaction details.
    /// </summary>

    public class DetailedRefund
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DetailedRefund() { }

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
        /// The note to the payer in this transaction.
        /// </summary>
        [JsonPropertyName("custom")]
        public string Custom;

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
        /// The currency and amount for a transaction.
        /// </summary>
        [JsonPropertyName("refund_from_received_amount")]
        public Currency RefundFromReceivedAmount;

        /// <summary>
        /// The currency and amount for a transaction.
        /// </summary>
        [JsonPropertyName("refund_from_transaction_fee")]
        public Currency RefundFromTransactionFee;

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
        /// The currency and amount for a transaction.
        /// </summary>
        [JsonPropertyName("total_refunded_amount")]
        public Currency TotalRefundedAmount;

        /// <summary>
        /// The date and time when the resource was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

