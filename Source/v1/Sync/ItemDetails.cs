




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// The item details.
    /// </summary>

    public class ItemDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ItemDetails() { }

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("adjustment_amount")]
        public Money AdjustmentAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("basic_shipping_amount")]
        public Money BasicShippingAmount;

        /// <summary>
        /// An array of checkout options. Each option has a name and value.
        /// </summary>
        [JsonPropertyName("checkout_options")]
        public List<CheckoutOption> CheckoutOptions;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public Money DiscountAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("extra_shipping_amount")]
        public Money ExtraShippingAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("gift_wrap_amount")]
        public Money GiftWrapAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("handling_amount")]
        public Money HandlingAmount;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("insurance_amount")]
        public Money InsuranceAmount;

        /// <summary>
        /// The invoice number. An alphanumeric string that identifies a billing for a merchant.
        /// </summary>
        [JsonPropertyName("invoice_number")]
        public string InvoiceNumber;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("item_amount")]
        public Money ItemAmount;

        /// <summary>
        /// An item code that identifies a merchant's goods or service.
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode;

        /// <summary>
        /// The item description.
        /// </summary>
        [JsonPropertyName("item_description")]
        public string ItemDescription;

        /// <summary>
        /// The item name.
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName;

        /// <summary>
        /// The item options. Describes option choices on the purchase of the item in some detail.
        /// </summary>
        [JsonPropertyName("item_options")]
        public string ItemOptions;

        /// <summary>
        /// The number of purchased units of goods or a service.
        /// </summary>
        [JsonPropertyName("item_quantity")]
        public string ItemQuantity;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("item_unit_price")]
        public Money ItemUnitPrice;

        /// <summary>
        /// An array of tax amounts levied by a government on the purchase of goods or services.
        /// </summary>
        [JsonPropertyName("tax_amounts")]
        public List<Tax> TaxAmounts;

        /// <summary>
        /// The percentage, as a fixed-point, signed decimal number. For example, define a 19.99% interest rate as `19.99`.
        /// </summary>
        [JsonPropertyName("tax_percentage")]
        public string TaxPercentage;

        /// <summary>
        /// The currency and amount for a financial value-related field. For example, balance or payment due.
        /// </summary>
        [JsonPropertyName("total_item_amount")]
        public Money TotalItemAmount;
    }
}

