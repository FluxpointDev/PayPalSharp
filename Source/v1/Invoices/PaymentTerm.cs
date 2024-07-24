




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The payment term of the invoice. If you specify `term_type`, you cannot specify `due_date`, and vice versa.
    /// </summary>

    public class PaymentTerm
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentTerm() { }

        /// <summary>
        /// The date when the invoice payment is due. This date must be a future date. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate;

        /// <summary>
        /// The term by which the invoice payment is due.
        /// </summary>
        [JsonPropertyName("term_type")]
        public string TermType;
    }
}

