




using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Invoice search parameters.
    /// </summary>

    public class Search
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Search() { }

        /// <summary>
        /// Indicates whether to list merchant-archived invoices in the response. If `true`, response lists only merchant-archived invoices. If `false`, response lists only unarchived invoices. If `null`, response lists all invoices.
        /// </summary>
        [JsonPropertyName("archived")]
        public bool? Archived;

        /// <summary>
        /// The initial letters of the email address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// The end creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("end_creation_date")]
        public string EndCreationDate;

        /// <summary>
        /// The end due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("end_due_date")]
        public string EndDueDate;

        /// <summary>
        /// The end date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("end_invoice_date")]
        public string EndInvoiceDate;

        /// <summary>
        /// The end payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("end_payment_date")]
        public string EndPaymentDate;

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("lower_total_amount")]
        public Currency LowerTotalAmount;

        /// <summary>
        /// The invoice number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;

        /// <summary>
        /// The offset for the search results.
        /// </summary>
        [JsonPropertyName("page")]
        public double? Page;

        /// <summary>
        /// The page size for the search results.
        /// </summary>
        [JsonPropertyName("page_size")]
        public double? PageSize;

        /// <summary>
        /// The initial letters of the recipient business name.
        /// </summary>
        [JsonPropertyName("recipient_business_name")]
        public string RecipientBusinessName;

        /// <summary>
        /// The initial letters of the recipient first name.
        /// </summary>
        [JsonPropertyName("recipient_first_name")]
        public string RecipientFirstName;

        /// <summary>
        /// The initial letters of the recipient last name.
        /// </summary>
        [JsonPropertyName("recipient_last_name")]
        public string RecipientLastName;

        /// <summary>
        /// The start creation date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("start_creation_date")]
        public string StartCreationDate;

        /// <summary>
        /// The start due date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("start_due_date")]
        public string StartDueDate;

        /// <summary>
        /// The start date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("start_invoice_date")]
        public string StartInvoiceDate;

        /// <summary>
        /// The start payment date for the invoice. Date format is *yyyy*-*MM*-*dd* *z*, as defined in [Internet Date/Time Format](http://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("start_payment_date")]
        public string StartPaymentDate;

        /// <summary>
        /// The invoice status. To search by status, specify this value as an array. For example, `"status": ["REFUNDED"]`.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// Indicates whether the total count appears in the response.
        /// </summary>
        [JsonPropertyName("total_count_required")]
        public bool? TotalCountRequired;

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("upper_total_amount")]
        public Currency UpperTotalAmount;
    }
}

