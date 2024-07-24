

// @version 0.1.0-dev+291f3f


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// Information about the disputed transaction.
    /// </summary>

    public class TransactionInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TransactionInformation() { }

        /// <summary>
        /// The details for the customer who funds the payment. For example, the customer's first name, last name, email address, and so on.
        /// </summary>
        [JsonPropertyName("buyer")]
        public Buyer Buyer;

        /// <summary>
        /// The ID, as seen by the customer, for this transaction.
        /// </summary>
        [JsonPropertyName("buyer_transaction_id")]
        public string BuyerTransactionId;

        /// <summary>
        /// The date and time, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Seconds are required while fractional seconds are optional.<blockquote><strong>Note:</strong> The regular expression provides guidance but does not reject all invalid dates.</blockquote>
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// A free-text field that is entered by the merchant during checkout.
        /// </summary>
        [JsonPropertyName("custom")]
        public string Custom;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("gross_amount")]
        public Money GrossAmount;

        /// <summary>
        /// The ID of the invoice that is associated with the payment.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// An array of items that were purchased as part of the transaction.
        /// </summary>
        [JsonPropertyName("items")]
        public List<ItemInformation> Items;

        /// <summary>
        /// The details for the merchant who receives the funds and fulfills the order. For example, merchant ID, contact email address, and so on.
        /// </summary>
        [JsonPropertyName("seller")]
        public Merchant Seller;

        /// <summary>
        /// The ID, as seen by the merchant, for this transaction.
        /// </summary>
        [JsonPropertyName("seller_transaction_id")]
        public string SellerTransactionId;

        /// <summary>
        /// The transaction status. Value is:<ul><li><code>COMPLETED</code>. The transaction processing is completed.</li><li><code>UNCLAIMED</code>. The items in the transaction are unclaimed. If they are not claimed within 30 days, the funds are returned to the sender.</li><li><code>DENIED</code>. The transaction was denied.</li><li><code>FAILED</code>. The transaction failed.</li><li><code>HELD</code>. The transaction is on hold.</li><li><code>PENDING</code>. The transaction is waiting to be processed.</li><li><code>PARTIALLY_REFUNDED</code>. Payment for the transaction was partially refunded.</li><li><code>REFUNDED</code>. Payment for the transaction was successfully refunded.</li><li><code>REVERSED</code>. Payment for the transaction was reversed due to a chargeback or other type of reversal.</li></ul>
        /// </summary>
        [JsonPropertyName("transaction_status")]
        public string TransactionStatus;
    }
}

