// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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
        /// The item name. Maximum length is 127 characters.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item cost. Supports two decimal places.
        /// </summary>
        [JsonPropertyName("price")]
        public string Price;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Must be a whole number.
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

