




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// A vaulted credit card. To fund a payment, use the ID of the vaulted card.
    /// </summary>

    public class CreditCard
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public CreditCard() { }

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public SimplePostalAddress BillingAddress;

        /// <summary>
        /// The date and time when the vaulted credit card was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// REQUIRED
        /// The one- to two-digit month when the card expires, with no leading zero. For example, `1` or `12`.
        /// </summary>
        [JsonPropertyName("expire_month")]
        public string ExpireMonth;

        /// <summary>
        /// REQUIRED
        /// The four-digit year when the card expires. For example, `2017`.
        /// </summary>
        [JsonPropertyName("expire_year")]
        public string ExpireYear;

        /// <summary>
        /// The externally-provided ID of the credit card.
        /// </summary>
        [JsonPropertyName("external_card_id")]
        public string ExternalCardId;

        /// <summary>
        /// The externally-provided ID of the customer for whom to list credit cards.
        /// </summary>
        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId;

        /// <summary>
        /// The first name of the credit card holder. Maximum length is 25 characters.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The ID of the vaulted credit card, which you can use to fund a payment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// The last name of the credit card holder.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the merchant for whom to list credit cards.
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId;

        /// <summary>
        /// REQUIRED
        /// The credit card number. Valid value is a string of numeric characters with no spaces or punctuation. Must conform to modulo and the length required by its credit card type. *Redacted in responses.*
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;

        /// <summary>
        /// A unique ID that you can assign and track when you vault a credit card or use a vaulted credit card to make a payment. This ID can help to avoid unintentional use or misuse of credit cards. Can be any value, such as a UUID, user name, or email address. **This is being deprecated in favor of the `external_customer_id` property.**
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The state of the credit card funding instrument.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// REQUIRED
        /// The credit card type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type;

        /// <summary>
        /// The date and time when the vaulted credit card was updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). For example, `2017-11-05T13:15:30Z`.
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTimeFormat;

        [JsonIgnore]
        public DateTime UpdateDate => DateTime.Parse(UpdateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The date and time when the credit card becomes unusable from the vault, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). The `valid_until` parameter is not the same as the expiration month and year. The expiration month and year might be later than the `valid_until` date. For example, the card expires in November 2019 but the `valid_until` date is October 17th, 2019.
        /// </summary>
        [JsonPropertyName("valid_until")]
        public string ValidUntilDateFormat;

        [JsonIgnore]
        public DateTime ValidUntilDate => DateTime.Parse(ValidUntilDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

