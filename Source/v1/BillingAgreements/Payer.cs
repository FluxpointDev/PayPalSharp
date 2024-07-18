




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// The customer who funds the payment.
    /// </summary>

    public class Payer
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Payer() { }

        /// <summary>
        /// An array of funding instruments.
        /// </summary>
        [JsonPropertyName("funding_instruments")]
        public List<FundingInstrument> FundingInstruments;

        /// <summary>
        /// The ID of the customer-selected funding option for the payment. Value is `funding_instruments` or `funding_option_id`.
        /// </summary>
        [JsonPropertyName("funding_option_id")]
        public string FundingOptionId;

        /// <summary>
        /// Information about the customer.
        /// </summary>
        [JsonPropertyName("payer_info")]
        public PayerInformation PayerInfo;

        /// <summary>
        /// REQUIRED
        /// The payment method.
        /// </summary>
        [JsonPropertyName("payment_method")]
        public string PaymentMethod;
    }
}

