

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// A request by a merchant to accept a customer merchandise claim.
    /// </summary>

    public class AcceptClaimRequest
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AcceptClaimRequest() { }

        /// <summary>
        /// The merchant's reason for acceptance of the customer's claim.
        /// </summary>
        [JsonPropertyName("accept_claim_reason")]
        public string AcceptClaimReason;

        /// <summary>
        /// The ID of the invoice for the refund.
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId;

        /// <summary>
        /// The merchant's notes about acceptance of the customer's claim.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;

        /// <summary>
        /// The portable international postal address. Maps to [AddressValidationMetadata](https://github.com/googlei18n/libaddressinput/wiki/AddressValidationMetadata) and HTML 5.1 [Autofilling form controls: the autocomplete attribute](https://www.w3.org/TR/html51/sec-forms.html#autofilling-form-controls-the-autocomplete-attribute).
        /// </summary>
        [JsonPropertyName("return_shipping_address")]
        public PortablePostalAddress PortablePostalAddress;
    }
}

