// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payment options for this transaction.
    /// </summary>

    public class PaymentOptions
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentOptions() { }

        /// <summary>
        /// The payment method for this transaction. This field does not apply to the credit card payment method. Value is:<ul><li><code>UNRESTRICTED</code>. Merchant does not have a preference on how they want the customer to pay.</li><li><code>INSTANT_FUNDING_SOURCE</code>. Merchant requires that the customer pays with an instant funding source, such as a credit card or PayPal balance. All payments are processed instantly. However, payments that require a manual review are marked as pending. Merchants must handle the pending state as if the payment is not yet complete.</li><li><code>IMMEDIATE_PAY</code>. Processes all payments immediately. Any payment that requires a manual review is marked failed.</li></ul>
        /// </summary>
        [JsonPropertyName("allowed_payment_method")]
        public string AllowedPaymentMethod;
    }
}

