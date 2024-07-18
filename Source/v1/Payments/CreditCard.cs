// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Deprecated. The credit card details. You can use this instrument to fund a payment. Use a payment card instead.
    /// </summary>

    public class CreditCard
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCard() { }

        /// <summary>
        /// The billing address or shipping address for a payment.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public Address BillingAddress;

        /// <summary>
        /// The three- to four-digit card validation code.
        /// </summary>
        [JsonPropertyName("cvv2")]
        public string Cvv2;

        /// <summary>
        /// REQUIRED
        /// The expiration month with no leading zero. Value is from `1` to `12`.
        /// </summary>
        [JsonPropertyName("expire_month")]
        public int? ExpireMonth;

        /// <summary>
        /// REQUIRED
        /// The four-digit expiration year.
        /// </summary>
        [JsonPropertyName("expire_year")]
        public int? ExpireYear;

        /// <summary>
        /// The card holder's first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The card holder's last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// REQUIRED
        /// The credit card number. Value is numeric characters only with no spaces or punctuation. Must conform to the modulo and length required by each credit card type. *Redacted in responses.*
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;

        /// <summary>
        /// REQUIRED
        /// The credit card type. Value is `visa`, `mastercard`, `discover`, or `amex`. Do not use these lowercase values for display.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;
    }
}

