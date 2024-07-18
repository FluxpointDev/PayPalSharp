




using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A payment card that can be used to fund a payment.
    /// </summary>

    public class PaymentCard
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentCard() { }

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public SimplePostalAddress BillingAddress;

        /// <summary>
        /// The card validation code. Supported only when making a payment but not when saving a payment card for future use.
        /// </summary>
        [JsonPropertyName("cvv2")]
        public int? Cvv2;

        /// <summary>
        /// REQUIRED
        /// The two-digit card expiry month.
        /// </summary>
        [JsonPropertyName("expire_month")]
        public int? ExpireMonth;

        /// <summary>
        /// REQUIRED
        /// The four-digit card expiry year.
        /// </summary>
        [JsonPropertyName("expire_year")]
        public int? ExpireYear;

        /// <summary>
        /// The facilitator-provided ID of the card holder. Required when storing a funding instrument or using a stored funding instrument in the PayPal vault.
        /// </summary>
        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId;

        /// <summary>
        /// The card holder's first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The ID of the vaulted payment card.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

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
        /// The card number.
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;

        /// <summary>
        /// The two-digit card start month.
        /// </summary>
        [JsonPropertyName("start_month")]
        public int? StartMonth;

        /// <summary>
        /// The four-digit card start year.
        /// </summary>
        [JsonPropertyName("start_year")]
        public int? StartYear;

        /// <summary>
        /// The status of the funding instrument.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status;

        /// <summary>
        /// REQUIRED
        /// The card type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;

        /// <summary>
        /// The date and time when the card becomes unusable from the vault, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The `valid_until` parameter is not the same as the expiration month and year. The expiration month and year might be later than the `valid_until` date. For example, the card expires in November 2019 but the `valid_until` date is October 17th, 2019.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public string ValidUntil;
    }
}

