// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// An array of items that are being purchased.
    /// </summary>

    public class ItemList
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ItemList() { }

        /// <summary>
        /// An array of items that are being purchased.
        /// </summary>
        [JsonPropertyName("items")]
        public List<Item> Items;

        /// <summary>
        /// The shipping address details.
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress;

        /// <summary>
        /// The shipping method used for this payment, such as USPS Parcel.
        /// </summary>
        [JsonPropertyName("shipping_method")]
        public string ShippingMethod;

        /// <summary>
        /// The shipping phone number, in its canonical international format as defined by the [E.164](https://en.wikipedia.org/wiki/E.164) numbering plan. Enables merchants to share payer’s contact number with PayPal for the current payment. The final contact number for the payer who is associated with the transaction might be the same as or different from the `shipping_phone_number` based on the payer’s action on PayPal.
        /// </summary>
        [JsonPropertyName("shipping_phone_number")]
        public string ShippingPhoneNumber;
    }
}

