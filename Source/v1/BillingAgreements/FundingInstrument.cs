using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Information about a customer's funding instrument.
    /// </summary>

    public class FundingInstrument
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FundingInstrument() { }

        /// <summary>
        /// A bank account that can be used to fund a payment. Supports Single Euro Payments Area (SEPA) bank accounts.
        /// </summary>
        [JsonPropertyName("bank_account")]
        public ExtendedBankAccount BankAccount;

        /// <summary>
        /// A token for a bank card. Can be used to fund a payment.
        /// </summary>
        [JsonPropertyName("bank_account_token")]
        public BankToken BankAccountToken;

        /// <summary>
        /// A payment card that can be used to fund a payment.
        /// </summary>
        [JsonPropertyName("payment_card")]
        public PaymentCard PaymentCard;

        /// <summary>
        /// A token for a payment card that can be used to fund a payment.
        /// </summary>
        [JsonPropertyName("payment_card_token")]
        public PaymentCardToken PaymentCardToken;
    }
}

