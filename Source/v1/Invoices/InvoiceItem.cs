




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Invoice line item information.
    /// </summary>

    public class InvoiceItem
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceItem() { }

        /// <summary>
        /// The date when the item or service was provided. The date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("date")]
        public string Date;

        /// <summary>
        /// The item description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description;

        /// <summary>
        /// The cost as a percent or an amount value. For example, to specify 10%, enter `10`. Alternatively, to specify an amount of 5, enter `5`.
        /// </summary>
        [JsonPropertyName("discount")]
        public Cost Discount;

        /// <summary>
        /// REQUIRED
        /// The item name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The item quantity. Valid value is from -10000 to 10000.
        /// </summary>
        [JsonPropertyName("quantity")]
        public double? Quantity;

        /// <summary>
        /// Tax information.
        /// </summary>
        [JsonPropertyName("tax")]
        public Tax Tax;

        /// <summary>
        /// The unit of measure for the invoiced item.
        /// </summary>
        [JsonPropertyName("unit_of_measure")]
        public string UnitOfMeasure;

        /// <summary>
        /// REQUIRED
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("unit_price")]
        public Currency UnitPrice;
    }
}

