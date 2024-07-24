




using System.Globalization;
using System;
using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The transaction information.
    /// </summary>

    public class TransactionInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TransactionInformation() { }

        /// <summary>
        /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as `19.99`.
        /// </summary>
        [JsonPropertyName("annual_percentage_rate")]
        public string AnnualPercentageRate;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("available_balance")]
        public Money AvailableBalance;

        /// <summary>
        /// The bank reference ID. The bank provides this value for an ACH transaction.
        /// </summary>
        [JsonPropertyName("bank_reference_id")]
        public string BankReferenceId;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("credit_promotional_fee")]
        public Money CreditPromotionalFee;

        /// <summary>
        /// The credit term. The time span covered by the installment payments as expressed in the term length plus the length time unit code.
        /// </summary>
        [JsonPropertyName("credit_term")]
        public string CreditTerm;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("credit_transactional_fee")]
        public Money CreditTransactionalFee;

        /// <summary>
        /// The merchant-provided custom text.<blockquote><strong>Note:</strong> Usually, this field includes the unique ID for payments made with MassPay type transaction.</blockquote>
        /// </summary>
        [JsonPropertyName("custom_field")]
        public string CustomField;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public Money DiscountAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("ending_balance")]
        public Money EndingBalance;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("fee_amount")]
        public Money FeeAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("insurance_amount")]
        public Money InsuranceAmount;

        /// <summary>
        /// The invoice ID that is sent by the merchant with the transaction.<blockquote><strong>Note:</strong> If an invoice ID was sent with the capture request, the value is reported. Otherwise, the invoice ID of the authorizing transaction is reported.</blockquote>
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("other_amount")]
        public Money OtherAmount;

        /// <summary>
        /// The payment method that was used for a transaction. Value is <code>PUI</code>, <code>installment</code>, or <code>mEFT</code>.<blockquote><strong>Note:</strong> Appears only for pay upon invoice (PUI), installment, and mEFT transactions. Merchants and partners in the EMEA region can use this attribute to note transactions that attract turn-over tax.</blockquote>
        /// </summary>
        [JsonPropertyName("payment_method_type")]
        public string PaymentMethodType;

        /// <summary>
        /// The payment tracking ID, which is a unique ID that partners specify to either get information about a payment or request a refund.
        /// </summary>
        [JsonPropertyName("payment_tracking_id")]
        public string PaymentTrackingId;

        /// <summary>
        /// The ID of the PayPal account of the payee.
        /// </summary>
        [JsonPropertyName("paypal_account_id")]
        public string PaypalAccountId;

        /// <summary>
        /// The PayPal-generated base ID. PayPal exclusive. Cannot be altered. Defined as a related, pre-existing transaction or event.
        /// </summary>
        [JsonPropertyName("paypal_reference_id")]
        public string PaypalReferenceId;

        /// <summary>
        /// The PayPal reference ID type. Value is:<ul><li><code>ODR</code>. An order ID.</li><li><code>TXN</code>. A transaction ID.</li><li><code>SUB</code>. A subscription ID.</li><li><code>PAP</code>. A preapproved payment ID.</li></ul>
        /// </summary>
        [JsonPropertyName("paypal_reference_id_type")]
        public string PaypalReferenceIdType;

        /// <summary>
        /// Indicates whether the transaction is eligible for protection. Value is:<ul><li><code>01</code>. Eligible.</li><li><code>02</code>. Not eligible</li><li><code>03</code>. Partially eligible.</li></ul>
        /// </summary>
        [JsonPropertyName("protection_eligibility")]
        public string ProtectionEligibility;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("sales_tax_amount")]
        public Money SalesTaxAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("shipping_amount")]
        public Money ShippingAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("shipping_discount_amount")]
        public Money ShippingDiscountAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("shipping_tax_amount")]
        public Money ShippingTaxAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("tip_amount")]
        public Money TipAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("transaction_amount")]
        public Money TransactionAmount;

        /// <summary>
        /// A five-digit transaction event code that classifies the transaction type based on money movement and debit or credit. For example, <code>T0001</code>. See [Transaction event codes](/docs/integration/direct/sync/transaction-event-codes/).
        /// </summary>
        [JsonPropertyName("transaction_event_code")]
        public string TransactionEventCode;

        /// <summary>
        /// The PayPal-generated transaction ID.
        /// </summary>
        [JsonPropertyName("transaction_id")]
        public string TransactionId;

        /// <summary>
        /// The date and time when work on a transaction began in the PayPal system, as expressed in the time zone of the account on this side of the payment. Specify the value in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("transaction_initiation_date")]
        public string TransactionInitiationDateFormat;

        [JsonIgnore]
        public DateTime TransactionInitiationDate => DateTime.Parse(TransactionInitiationDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// A special note that the payer passes to the payee. Might contain special customer requests, such as shipping instructions.
        /// </summary>
        [JsonPropertyName("transaction_note")]
        public string TransactionNote;

        /// <summary>
        /// A code that indicates the transaction status. Value is:<table><thead><tr><th>Status&nbsp;code</th><th>Description</th></tr></thead><tbody><tr><td><code>D</code></td><td>PayPal or merchant rules denied the transaction.</td></tr><tr><td><code>F</code></td><td>The original recipient partially refunded the transaction.</td></tr><tr><td><code>P</code></td><td>The transaction is pending. The transaction was created but waits for another payment process to complete, such as an ACH transaction, before the status changes to <code>S</code>.</td></tr><tr><td><code>S</code></td><td>The transaction successfully completed without a denial and after any pending statuses.</td></tr><tr><td><code>V</code></td><td>A successful transaction was reversed and funds were refunded to the original sender.</td></tr></tbody></table>
        /// </summary>
        [JsonPropertyName("transaction_status")]
        public string TransactionStatus;

        /// <summary>
        /// The subject of payment. The payer passes this value to the payee. The payer controls this data through the interface through which he or she sends the data.
        /// </summary>
        [JsonPropertyName("transaction_subject")]
        public string TransactionSubject;

        /// <summary>
        /// The date and time when the transaction was last changed, as expressed in the time zone of the account on this side of the payment. Specify the value in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("transaction_updated_date")]
        public string TransactionUpdatedDateFormat;

        [JsonIgnore]
        public DateTime TransactionUpdatedDate => DateTime.Parse(TransactionUpdatedDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

