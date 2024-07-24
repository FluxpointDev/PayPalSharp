




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{

    public class InvoiceNumber
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceNumber() { }

        /// <summary>
        /// The next invoice number that is available to the merchant. This number is auto-incremented from the most recent invoice number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;
    }
}

