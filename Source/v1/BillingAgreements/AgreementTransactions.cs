




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// An array of agreement transactions.
    /// </summary>

    public class AgreementTransactions
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AgreementTransactions() { }

        /// <summary>
        /// An array of agreement transaction objects.
        /// </summary>
        [JsonPropertyName("agreement_transaction_list")]
        public List<AgreementTransaction> AgreementTransactionList;
    }
}

