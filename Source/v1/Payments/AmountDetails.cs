// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
{
    /// <summary>
    /// The additional details about the payment amount.
    /// </summary>

    public class AmountDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AmountDetails() { }

        /// <summary>
        /// The gift wrap fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("gift_wrap")]
        public string GiftWrap;

        /// <summary>
        /// The handling fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("handling_fee")]
        public string HandlingFee;

        /// <summary>
        /// The insurance fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported only for the PayPal payment method.
        /// </summary>
        [JsonPropertyName("insurance")]
        public string Insurance;

        /// <summary>
        /// The shipping fee. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("shipping")]
        public string Shipping;

        /// <summary>
        /// The shipping fee discount. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>Supported for the PayPal payment method only.
        /// </summary>
        [JsonPropertyName("shipping_discount")]
        public string ShippingDiscount;

        /// <summary>
        /// The subtotal amount for the items. If the request includes line items, this property is **required**. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("subtotal")]
        public string Subtotal;

        /// <summary>
        /// The tax. Maximum length is 10 characters, which includes:<ul><li>Seven digits before the decimal point.</li><li>The decimal point.</li><li>Two digits after the decimal point.</li></ul>
        /// </summary>
        [JsonPropertyName("tax")]
        public string Tax;
    }
}

