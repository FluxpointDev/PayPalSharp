




using System.Text.Json.Serialization;

namespace PayPal.v1.Sync
{
    /// <summary>
    /// The name of the party.
    /// </summary>

    public class Name
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Name() { }

        /// <summary>
        /// The party's alternate name. Can be a business name, nickname, or any other name that cannot be split into first, last name. Required for a business party name.
        /// </summary>
        [JsonPropertyName("alternate_full_name")]
        public string AlternateFullName;

        /// <summary>
        /// The party's given, or first, name. Required if the party is a person.
        /// </summary>
        [JsonPropertyName("given_name")]
        public string GivenName;

        /// <summary>
        /// The party's middle name. Use also to store multiple middle names including the patronymic, or father's, middle name.
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName;

        /// <summary>
        /// The prefix, or title, to the party name.
        /// </summary>
        [JsonPropertyName("prefix")]
        public string Prefix;

        /// <summary>
        /// The suffix for the party's name.
        /// </summary>
        [JsonPropertyName("suffix")]
        public string Suffix;

        /// <summary>
        /// The party's surname or family name. Also known as the last name. Required if the party is a person. Use also to store multiple surnames including the matronymic, or mother's, surname.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname;
    }
}

