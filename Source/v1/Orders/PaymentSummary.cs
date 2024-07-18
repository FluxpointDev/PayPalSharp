




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payment summary.
    /// </summary>

    public class PaymentSummary
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentSummary() { }

        /// <summary>
        /// An array of authorizations for a purchase unit. A purchase unit can have zero or more authorizations.
        /// </summary>
        [JsonPropertyName("authorizations")]
        public List<Sale> Authorizations;

        /// <summary>
        /// An array of captures for a purchase unit. A purchase unit can have zero or more captures.
        /// </summary>
        [JsonPropertyName("captures")]
        public List<Capture> Captures;

        /// <summary>
        /// An array of refunds for a purchase unit. A purchase unit can have zero or more refunds.
        /// </summary>
        [JsonPropertyName("refunds")]
        public List<Refund> Refunds;

        /// <summary>
        /// An array of sales for a purchase unit. A purchase unit can have zero or more sales.
        /// </summary>
        [JsonPropertyName("sales")]
        public List<Sale> Sales;
    }
}

