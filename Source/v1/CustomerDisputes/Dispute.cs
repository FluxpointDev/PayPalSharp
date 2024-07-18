

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The dispute details.
    /// </summary>

    public class Dispute
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Dispute() { }

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("dispute_amount")]
        public Money DisputeAmount;

        /// <summary>
        /// The ID of the dispute.
        /// </summary>
        [JsonPropertyName("dispute_id")]
        public string DisputeId;

        /// <summary>
        /// The outcome of a dispute.
        /// </summary>
        [JsonPropertyName("dispute_outcome")]
        public DisputeOutcome DisputeOutcome;

        /// <summary>
        /// An array of transactions for which the disputes were created.
        /// </summary>
        [JsonPropertyName("disputed_transactions")]
        public List<TransactionInformation> DisputedTransactions;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/hateoas-links/).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescription> Links;

        /// <summary>
        /// An array of messages that were posted by the customer and merchant.
        /// </summary>
        [JsonPropertyName("messages")]
        public List<Message> Messages;

        /// <summary>
        /// The information for the offer that a buyer or seller proposes for the dispute.
        /// </summary>
        [JsonPropertyName("offer")]
        public Offer Offer;

        /// <summary>
        /// The reason for the item-level dispute. Value is:<ul><li><code>MERCHANDISE_OR_SERVICE_NOT_RECEIVED</code>. The customer did not receive the merchandise or service.</li><li><code>MERCHANDISE_OR_SERVICE_NOT_AS_DESCRIBED</code>. The customer reports that the merchandise or service was not as described.</li><li><code>UNAUTHORISED</code>. The customer did not authorize purchase of the merchandise or service.</li><li><code>CREDIT_NOT_PROCESSED</code>. The refund or credit was not processed for the customer.</li><li><code>DUPLICATE_TRANSACTION</code>. The transaction was a duplicate.</li><li><code>INCORRECT_AMOUNT</code>. The customer was charged an incorrect amount.</li><li><code>PAYMENT_BY_OTHER_MEANS</code>. The customer paid for the transaction through other means.</li><li><code>CANCELED_RECURRING_BILLING</code>. The customer was being charged for a subscription or recurring transaction that was canceled.</li><li><code>PROBLEM_WITH_REMITTANCE</code>. A problem occurred with the remittance.</li><li><code>OTHER</code>. Other.</li></ul>For information about the required information for each dispute reason and associated evidence type, see <a href="/docs/integration/direct/customer-disputes/#dispute-reason-codes">dispute reason codes</a>.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("seller_response_due_date")]
        public string SellerResponseDueDate;

        /// <summary>
        /// The status of the dispute. Value is:<ul><li><code>OPEN</code>. Open.</li><li><code>WAITING_FOR_BUYER_RESPONSE</code>. The dispute is waiting for a response from the customer.</li><li><code>WAITING_FOR_SELLER_RESPONSE</code>. The dispute is waiting for a response from the merchant.</li><li><code>UNDER_REVIEW</code>. The dispute is under review.</li><li><code>RESOLVED</code>. The dispute is resolved.</li><li><code>OTHER</code>. Another reason.</li></ul>
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime;
    }
}

