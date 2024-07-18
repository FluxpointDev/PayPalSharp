




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// The cart information.
    /// </summary>

    public class CartInformation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CartInformation() { }

        /// <summary>
        /// An array of item details.
        /// </summary>
        [JsonPropertyName("item_details")]
        public List<ItemDetails> ItemDetails;

        /// <summary>
        /// The ID of the invoice. Appears only for PayPal-generated invoices.
        /// </summary>
        [JsonPropertyName("paypal_invoice_id")]
        public string PaypalInvoiceId;

        /// <summary>
        /// Indicates whether the item amount or the shipping amount already includes tax.
        /// </summary>
        [JsonPropertyName("tax_inclusive")]
        public bool? TaxInclusive;
    }
}

