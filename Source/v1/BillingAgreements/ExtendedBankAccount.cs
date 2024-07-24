




using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A bank account that can be used to fund a payment. Supports Single Euro Payments Area (SEPA) bank accounts.
    /// </summary>

    public class ExtendedBankAccount
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ExtendedBankAccount() { }

        /// <summary>
        /// A customer-designated account name.
        /// </summary>
        [JsonPropertyName("account_name")]
        public string AccountName;

        /// <summary>
        /// REQUIRED
        /// The account number in international bank account number (IBAN) format or basic bank account number (BBAN) format. The maximum length for the IBAN format is 34 characters. The maximum length for the BBAN format is 17 characters.
        /// </summary>
        [JsonPropertyName("account_number")]
        public string AccountNumber;

        /// <summary>
        /// REQUIRED
        /// The type of bank account number. A valid value is basic bank account number (BBAN) or international bank account number (IBAN). For more information, see [International Bank Account Number](http://en.wikipedia.org/wiki/International_Bank_Account_Number).
        /// </summary>
        [JsonPropertyName("account_number_type")]
        public string AccountNumberType;

        /// <summary>
        /// The bank account type.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType;

        /// <summary>
        /// The date and time when the authorization was captured, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6). Use this parameter if you must capture the user authorization due to any privacy requirements.
        /// </summary>
        [JsonPropertyName("auth_capture_timestamp")]
        public string AuthCaptureTimestampFormat;

        [JsonIgnore]
        public DateTime AuthCaptureTimestampDate => DateTime.Parse(AuthCaptureTimestampFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The authorization type, which indicates how the check was obtained from the customer if a check is the source of information.
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType;

        /// <summary>
        /// The bank name.
        /// </summary>
        [JsonPropertyName("bank_name")]
        public string BankName;

        /// <summary>
        /// A simple postal address with coarse-grained fields. Do not use for an international address. Use for backward compatibility only. Does not contain phone.
        /// </summary>
        [JsonPropertyName("billing_address")]
        public SimplePostalAddress BillingAddress;

        /// <summary>
        /// The account holder's birth date.
        /// </summary>
        [JsonPropertyName("birth_date")]
        public string BirthDate;

        /// <summary>
        /// The check type when the information was obtained from the facilitator or merchant.
        /// </summary>
        [JsonPropertyName("check_type")]
        public string CheckType;

        /// <summary>
        /// The confirmation status of a bank account.
        /// </summary>
        [JsonPropertyName("confirmation_status")]
        public string ConfirmationStatus;

        /// <summary>
        /// The two-letter country code of the bank.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The date and time when the bank account was created, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The facilitator-generated ID for the customer who owns this bank account. Required when you create or use a vaulted funding instrument.
        /// </summary>
        [JsonPropertyName("external_customer_id")]
        public string ExternalCustomerId;

        /// <summary>
        /// The account holder's first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The ID of the bank account that is being saved for later use.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// The account holder's last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;

        /// <summary>
        /// An array of request-related [HATEOAS links](/docs/api/overview/#hateoas-links).
        /// </summary>
        [JsonPropertyName("links")]
        public List<LinkDescriptionObject> Links;

        /// <summary>
        /// The ID of the direct debit mandate to validate. Currently supported for only Single Euro Payments Area (SEPA) bank accounts in the European Union (EU).
        /// </summary>
        [JsonPropertyName("mandate_reference_number")]
        public string MandateReferenceNumber;

        /// <summary>
        /// The facilitator-generated ID for the merchant for whom the bank account was vaulted. Can be used to restrict usage of the bank account to the merchant.
        /// </summary>
        [JsonPropertyName("merchant_id")]
        public string MerchantId;

        /// <summary>
        /// Deprecated. Instead, use the `external_customer_id` parameter.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The routing transit number, or bank code, of the bank. Typically, you specify this value for domestic use only. International bank account numbers (IBAN) include the bank code. For more information, see [Bank code](http://en.wikipedia.org/wiki/Bank_code).
        /// </summary>
        [JsonPropertyName("routing_number")]
        public string RoutingNumber;

        /// <summary>
        /// The state of this funding instrument.
        /// </summary>
        [JsonPropertyName("state")]
        public string State;

        /// <summary>
        /// The date and time when the bank account was last updated, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTimeFormat;

        [JsonIgnore]
        public DateTime UpdateDate => DateTime.Parse(UpdateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);

        /// <summary>
        /// The date and time after which the bank account can no longer be used to fund a payment, in [Internet date and time format](https://tools.ietf.org/html/rfc3339#section-5.6).
        /// </summary>
        [JsonPropertyName("valid_until")]
        public string ValidUntilDateFormat;

        [JsonIgnore]
        public DateTime ValidUntilDate => DateTime.Parse(ValidUntilDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
}

