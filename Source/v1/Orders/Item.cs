




using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The item details.
    /// </summary>

    public class Item
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Item() { }

        /// <summary>
        /// REQUIRED
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/).
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency;

        /// <summary>
        /// The item description. Supported only for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// REQUIRED
        /// The item name. Maximum length is 127 characters.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item cost. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("price")]
        public string Price;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Maximum length is 10 characters.
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity;

        /// <summary>
        /// The stock keeping unit (SKU) for the item.
        /// </summary>
        [JsonPropertyName("sku")]
        public string Sku;

        /// <summary>
        /// The item tax. Supported only for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("tax")]
        public string Tax;

        /// <summary>
        /// The URL to item information. Available to the payer in the transaction history.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;
    }
}

