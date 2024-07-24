




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingPlans
{
    /// <summary>
    /// The merchant preferences for a plan. Includes how much it costs to set up the agreement, the URLs where the customer can approve or cancel the agreement, the maximum number of allowed failed payment attempts, whether PayPal automatically bills the outstanding balance in the next billing cycle, and the action if the customer's initial payment fails.
    /// </summary>

    public class MerchantPreferences
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public MerchantPreferences() { }

        /// <summary>
        /// The payment types that are accepted for this plan. Read-only and reserved for future use.
        /// </summary>
        [JsonPropertyName("accepted_payment_type")]
        public string AcceptedPaymentType;

        /// <summary>
        /// Indicates whether PayPal automatically bills the outstanding balance in the next billing cycle. The outstanding balance is the total amount of any previously failed scheduled payments. Value is:<ul><li><code>NO</code>. PayPal does not automatically bill the customer the outstanding balance. Default is <code>NO</code>.</li><li><code>YES</code>. PayPal automatically bills the customer the outstanding balance.</li><ul>
        /// </summary>
        [JsonPropertyName("auto_bill_amount")]
        public string AutoBillAmount;

        /// <summary>
        /// REQUIRED
        /// The URL where the customer can cancel the agreement.
        /// </summary>
        [JsonPropertyName("cancel_url")]
        public string CancelUrl;

        /// <summary>
        /// The character set for this plan. Read-only and reserved for future use.
        /// </summary>
        [JsonPropertyName("char_set")]
        public string CharSet;

        /// <summary>
        /// The action if the customer's initial payment fails. Value is:<ul><li><code>CONTINUE</code>. The agreement remains active and the failed payment amount is added to the outstanding balance. If auto-billing is enabled, PayPal automatically bills the outstanding balance in the next billing cycle. Default is `CONTINUE`.</li><li><code>CANCEL</code> PayPal creates the agreement but sets its state to pending until the initial payment clears. If the initial payment clears, the pending agreement becomes active. If the initial payment fails, the pending agreement is canceled.</li></ul><blockquote><strong>Note:</strong> You can use the `setup_fee` value as the initial amount to trigger the `initial_fail_amount_action`.</blockquote>
        /// </summary>
        [JsonPropertyName("initial_fail_amount_action")]
        public string InitialFailAmountAction;

        /// <summary>
        /// The maximum number of allowed failed payment attempts. Default is `0`, which allows infinite failed payment attempts.
        /// </summary>
        [JsonPropertyName("max_fail_attempts")]
        public string MaxFailAttempts;

        /// <summary>
        /// The URL where the customer is notified that the agreement was created. Read-only and reserved for future use.
        /// </summary>
        [JsonPropertyName("notify_url")]
        public string NotifyUrl;

        /// <summary>
        /// REQUIRED
        /// The URL where the customer can approve the agreement.
        /// </summary>
        [JsonPropertyName("return_url")]
        public string ReturnUrl;

        /// <summary>
        /// The base object for all financial value-related fields, such as balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("setup_fee")]
        public Currency SetupFee;
    }
}

