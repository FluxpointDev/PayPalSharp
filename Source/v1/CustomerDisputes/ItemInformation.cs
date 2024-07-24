

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The information for the purchased item in a disputed transaction.
    /// </summary>

    public class ItemInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ItemInformation() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("dispute_amount")]
        public Money DisputeAmount;

        /// <summary>
        /// The ID of the item.
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId;

        /// <summary>
        /// Any notes provided with the item.
        /// </summary>
        [JsonPropertyName("notes")]
        public string Notes;

        /// <summary>
        /// The ID of the transaction in the partner system. The partner transaction ID is returned at an item level because the partner might show different transactions for different items in the cart.
        /// </summary>
        [JsonPropertyName("partner_transaction_id")]
        public string PartnerTransactionId;

        /// <summary>
        /// The reason for the item-level dispute. Value is:<ul><li><code>MERCHANDISE_OR_SERVICE_NOT_RECEIVED</code>. The customer did not receive the merchandise or service.</li><li><code>MERCHANDISE_OR_SERVICE_NOT_AS_DESCRIBED</code>. The customer reports that the merchandise or service was not as described.</li><li><code>UNAUTHORISED</code>. The customer did not authorize purchase of the merchandise or service.</li><li><code>CREDIT_NOT_PROCESSED</code>. The refund or credit was not processed for the customer.</li><li><code>DUPLICATE_TRANSACTION</code>. The transaction was a duplicate.</li><li><code>INCORRECT_AMOUNT</code>. The customer was charged an incorrect amount.</li><li><code>PAYMENT_BY_OTHER_MEANS</code>. The customer paid for the transaction through other means.</li><li><code>CANCELED_RECURRING_BILLING</code>. The customer was being charged for a subscription or recurring transaction that was canceled.</li><li><code>PROBLEM_WITH_REMITTANCE</code>. A problem occurred with the remittance.</li><li><code>OTHER</code>. Other.</li></ul>For information about the required information for each dispute reason and associated evidence type, see <a href="/docs/integration/direct/customer-disputes/#dispute-reason-codes">dispute reason codes</a>.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason;
    }
}

