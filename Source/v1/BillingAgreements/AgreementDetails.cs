




using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// The agreement details.
    /// </summary>

    public class AgreementDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AgreementDetails() { }

        /// <summary>
        /// The number of payment cycles completed for this agreement.
        /// </summary>
        [JsonPropertyName("cycles_completed")]
        public string CyclesCompleted;

        /// <summary>
        /// The number of payment cycles remaining for this agreement.
        /// </summary>
        [JsonPropertyName("cycles_remaining")]
        public string CyclesRemaining;

        /// <summary>
        /// The total number of failed payments for this agreement.
        /// </summary>
        [JsonPropertyName("failed_payment_count")]
        public string FailedPaymentCount;

        /// <summary>
        /// The final payment date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-09-23T08:00:00Z`.
        /// </summary>
        [JsonPropertyName("final_payment_date")]
        public string FinalPaymentDate;

        /// <summary>
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("last_payment_amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue LastPaymentAmount;

        /// <summary>
        /// The last payment date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2016-12-23T08:00:00Z`.
        /// </summary>
        [JsonPropertyName("last_payment_date")]
        public string LastPaymentDate;

        /// <summary>
        /// The next billing date and time for this agreement, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-01-23T08:00:00Z`.
        /// </summary>
        [JsonPropertyName("next_billing_date")]
        public string NextBillingDate;

        /// <summary>
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("outstanding_balance")]
        public MoneyTypeWithCurrencyCodeQualifiedValue OutstandingBalance;
    }
}

