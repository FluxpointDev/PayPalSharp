



// @data H4sIAAAAAAAC/+yYS3PbNhDH7/0UO+wl0dBUW/cx1a2NkxlPJ0kncXuxPfIKWJrogAALLJ0ynXz3DviyKJJqmrrqQT5qH8D+fwDFXf4ZXVQFRavoLaETWRRHv6JTuNH0CvNgj+LoJ6ruf5yRF04VrKyJVtG5ubNKEPg6Gwp0mBOT80kURz84h1Wz/Bdx9IZQvja6ilYpak/B8HupHMne8LOzBTlW5KPVZV/YxlpNaMaVhR3VHclBhVvG3UqlEsjk4V1GnJEDtqCVZ8jJiQwNn3S5oBpVHpQBzggc+cIaTwmcp3DDrqSbuDfWi3iwRld7lmpSa6EzuaWZSTKl1uMc1Po+7l/CDjt8iHvinp0yt2PglKPSA9qdZYj6IiNQRrFCDZo4XAewaU2yTgCU0pE/WNlGroUjDNWtJTINJUx4x3LISOiiIERBal2tqD2DBM5aa44MysOiqqpqcbJ4+XJxspByAYv3ixjQg6RUmfqQ4fLcMDlDXCcvL1RO8KJe4fpJxlyslku2VvtEEaeJdbfLjHO9dKk4PT39/nNPItRz8k3y7dMDspQlTWPcckwTlCUdO7xW8TTAHecMxOMGWGCVk+FpgDvOaYBt0DGAfFY6R0ZUY5TaviO3Zsuo15jb0vAA5qR7iPNH9AR28xsJrimGF1KqDBoR/vfvUJfhxamRSUKqSEsPTzao0QiK78+gpBiIRfL0wfqFucsjWhbPrBxeHHEPaajwtH17QRcBwkraPvxNBedvX8PXX3353YEegZrroPzOMqy9OTQoi9DmvAKpbhUDpkFNuO6ShMpRe/AUejYO5ze4052s/gHBonC2cCo8HgMe/0h46J0mdF9/hHJT5htyA+m9aar/aBrTJuSBD6ffd6fEAm+HZ9MaxuXZNPXEPdy2fXbkS83+gNWuvXo/LrmzjusOXgjew5Q+dxccCVWo8E+/Kb0y5P3aBM+2kPmYj+5W+yWgWwLCEgcXmSrneZ/CQcAnyKvz/x9tGvdL2/Z/grKQfkhhntHxnnFj2j8WVsc9jhw9scmhY+Sa43jkg0fDaXb0mHTPojx2jLMDyKR7DuMRDSF7cHLpdxE2pvmGrglJ4MJ2rcemao0x+IKESivgTPl2BEEPaACDnCQAAfoD80JTDDdX7X5X0Qour6I3z1/88urs+dlVdH3zwAhmv2E2E5YIvfradQtuE5kJ+NtvmxlBnQp1aujeCd34g+ahxs2yKPaNm5Pux3Hzcdz8r8bN6w+f/QUAAP//
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

