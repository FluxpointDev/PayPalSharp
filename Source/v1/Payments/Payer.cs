// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// The payer. The payer funds the payment.
    /// </summary>

    public class Payer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payer() { }

        /// <summary>
        /// An array of a single funding instrument for the current payment. Valid only and required for the credit card payment method. The array must include either a `credit_card` or `credit_card_token` object. If the array contains more than one instrument, the payment is declined.
        /// </summary>
        [JsonPropertyName("funding_instruments")]
        public List<FundingInstrument> FundingInstruments;

        /// <summary>
        /// The payer information.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInformation PayerInfo;

        /// <summary>
        /// The payment method. Value is <code>paypal</code> for a PayPal Wallet payment.<blockquote><strong>Important:</strong> The use of the PayPal REST <code>/payments</code> APIs to accept credit card payments is restricted. Instead, you can accept credit card payments with:<ul><li><a href="/docs/integration/direct/payments/guest-payments/">Guest payments</a> with a <a href="/docs/api/vault/#credit-card_create">credit card that is stored in the PayPal vault</a></li><li><a href="https://www.braintreepayments.com/products/braintree-direct">Braintree Direct</a></li><li><a href="https://www.paypal.com/us/webapps/mpp/merchant">PayPal business products</a></li></ul></blockquote>
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod;

        /// <summary>
        /// The status of payer's PayPal account.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;
    }
}

