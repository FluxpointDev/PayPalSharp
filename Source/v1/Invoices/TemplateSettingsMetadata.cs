



// @data H4sIAAAAAAAC/6SOT0sDQQxH736KIedFPO9N8CLiH7R4EQ9p51cnkJ1dkxQZpN9dltqV4rHHPJKX902rNoF6WmGYlAPpBRFSPzzdIzhzMHX0yia8VjzwMO9SR3dof8MNfGMyhYx1NhWkONr8aBt+bZfU0bUZt8Pfq46ewfmxaqN+y+qYwedODHkBTzZOsBA49W9L8XocFVz/5xXJGfUkckGnqbc1y4YDnr4KosBSFPG0FWhO4ulwdm5y3anu3/cXPwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The template settings metadata.
    /// </summary>

    public class TemplateSettingsMetadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettingsMetadata() { }

        /// <summary>
        /// Indicates whether this field is hidden.
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool? Hidden;
    }
}

