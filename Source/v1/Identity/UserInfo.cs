




using System.Text.Json.Serialization;

namespace PayPal.v1.Identity
{
    /// <summary>
    /// Open ID Connect user information.documentationLink:http://openid.net/specs/openid-connect-basic-1_0.html#StandardClaims
    /// </summary>

    public class UserInfo
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public UserInfo() { }

        /// <summary>
        /// An enumeration of the account types.
        /// </summary>
        [JsonPropertyName("account_type")]
        public string AccountType;

        /// <summary>
        /// The end user's preferred address.
        /// </summary>
        [JsonPropertyName("address")]
        public UserAddress Address;

        /// <summary>
        /// The account holder's age range.
        /// </summary>
        [JsonPropertyName("age_range")]
        public string AgeRange;

        /// <summary>
        /// The end user's birthday, in `YYYY-MM-DD` format. The year MAY be `0000`, which indicates that the year is omitted. To represent only the year, use the `YYYY` format.
        /// </summary>
        [JsonPropertyName("birthdate")]
        public string Birthdate;

        /// <summary>
        /// The end user's preferred e-mail address.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;

        /// <summary>
        /// Indicates whether the end user's email address is verified.
        /// </summary>
        [JsonPropertyName("email_verified")]
        public bool? EmailVerified;

        /// <summary>
        /// The surname, or last name or names, of the end user.
        /// </summary>
        [JsonPropertyName("family_name")]
        public string FamilyName;

        /// <summary>
        /// The end user's gender.
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender;

        /// <summary>
        /// The given, or first, name or names of the end user.
        /// </summary>
        [JsonPropertyName("given_name")]
        public string GivenName;

        /// <summary>
        /// The end user's locale.
        /// </summary>
        [JsonPropertyName("locale")]
        public string Locale;

        /// <summary>
        /// The middle name of the end user.
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName;

        /// <summary>
        /// The end user's full name in displayable form including all name parts. Possibly includes titles and suffixes sorted according to the end user's locale and preferences.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The ID of the account payer.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// The end user's preferred telephone number.
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber;

        /// <summary>
        /// The URL of the end user's profile picture.
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture;

        /// <summary>
        /// The subject ID for the end user at the issuer.
        /// </summary>
        [JsonPropertyName("sub")]
        public string Sub;

        /// <summary>
        /// The ID of the end user at the issuer.
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId;

        /// <summary>
        /// The verified account status.
        /// </summary>
        [JsonPropertyName("verified_account")]
        public bool? VerifiedAccount;

        /// <summary>
        /// The end user's time zone.
        /// </summary>
        [JsonPropertyName("zoneinfo")]
        public string Zoneinfo;
    }
}

