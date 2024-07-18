




using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// An agreement transaction. Returned for a transaction search.
    /// </summary>

    public class AgreementTransaction
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AgreementTransaction() { }

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue Amount;

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue FeeAmount;

        /// <summary>
        /// REQUIRED
        /// A type for all financial value-related fields. For example, balance, payment due, and so on.
        /// </summary>
        [JsonPropertyName("net_amount")]
        public MoneyTypeWithCurrencyCodeQualifiedValue NetAmount;

        /// <summary>
        /// The email ID of the customer.
        /// </summary>
        [JsonPropertyName("payer_email")]
        public string PayerEmail;

        /// <summary>
        /// The business name of the customer.
        /// </summary>
        [JsonPropertyName("payer_name")]
        public string PayerName;

        /// <summary>
        /// The current status of the transaction. Value is:<ul><li>`Completed`. The transaction is complete and the money has been transfered to the payee.</li><li>`Partially_Refunded`. A part of the transaction amount has been refunded to the payer.</li><li>`Pending`. The transaction is pending settlement.</li><li>`Refunded`. The transaction amount has been refunded to the payer.</li><li>`Denied`. The transaction has been denied.</li></ul>
        /// </summary>
        [JsonPropertyName("status")]
        public AgreementTransactionStatusType Status;

        /// <summary>
        /// The date and time when the transaction occurred, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("time_stamp")]
        public string TimeStamp;

        /// <summary>
        /// The time zone of the `update_time` field.
        /// </summary>
        [JsonPropertyName("time_zone")]
        public string TimeZone;

        /// <summary>
        /// The ID of the transaction.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The type of transaction. Typically, `Recurring Payment`.
        /// </summary>
        [JsonPropertyName("transaction_type")]
        public string TransactionType;
    }

    public enum AgreementTransactionStatusType
    {
        [EnumMember(Value = "Completed")]
        Completed,

        [EnumMember(Value = "Partially_Refunded")]
        PartiallyRefunded,

        [EnumMember(Value = "Refunded")]
        Refunded,

        [EnumMember(Value = "Pending")]
        Pending,

        [EnumMember(Value = "Denied")]
        Denied
    }
}

