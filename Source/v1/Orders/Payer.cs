




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payer. The payer funds the payment.
    /// </summary>

    public class OrderPayer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public OrderPayer() { }

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
        /// The payment method. Value is PayPal Wallet payment, bank direct debit, or direct credit card.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod;
    }
}

