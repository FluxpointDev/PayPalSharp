




using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A token for a bank card. Can be used to fund a payment.
    /// </summary>

    public class BankToken
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public BankToken() { }

        /// <summary>
        /// REQUIRED
        /// The ID of the vaulted bank card.
        /// </summary>
        [JsonPropertyName("bank_id")]
        public string BankId;

        /// <summary>
        /// REQUIRED
        /// The ID of the customer who owns the bank card.
        /// </summary>
        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId;

        /// <summary>
        /// The ID of the direct debit mandate to validate. Supported only for Single Euro Payments Area (SEPA) bank accounts in the European Union (EU).
        /// </summary>
        [JsonPropertyName("mandate_reference_number")]
        public string MandateReferenceNumber;
    }
}

