



// @data H4sIAAAAAAAC/7SUT4vbPBDG7++nGHTJu2DZ8bakkFvp7mEp24Zt6CUsYWJNYoEsqSO5qSn97kWJ82/dQqHp0c9oZn7zjOTvYt55ElMxw44I7nTwBjt4pIgKI4pMfEbWuDL0AZt0TmTiPXWnjzsKFWsftbNiKuY1gdrXkM6aDpq+EKwdQ6wJfOqTi0y8ZcZu33yciSdC9dGaTkzXaAIl4UurmdRRmLHzxFFTENPFETtE1nYzxFwxWrW06eMc+EIeoic4HgVYtUFbCgHSyb+Fta0xP7Ij8cHiWe0sDcF795a+D5/YX0Z+jU+jALsTYNtmRfzvra5cayN3y8qpS+AXgSHvIm6drGpkrCIxPHway1flZCJL6FMhpT7/X8fow7QoFH0lk9Byj51Hk1euKZSrQqFtpA1jql0ozVTFginEoq8jU51Q3IBbny7hKBzaXHnDvzNqv5ALi47S0Bxt5cGF831moC0s7vNy8rpXtN2AN2jTE2swnuzabre5jm2ubXKjKuby6f6d3KXK23E5Lkv5cHOV2Z//YHpqUJuL4Q/KcPZdBFApTo/w/NfBOTziN920DRiym1iDDlDevoHjNQpXmui/nwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The display-only metadata for the payee.
    /// </summary>

    public class PayeeDisplayMetadata
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PayeeDisplayMetadata() { }

        /// <summary>
        /// The payer's business name.
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName;

        /// <summary>
        /// The payee's phone number.
        /// </summary>
        [JsonPropertyName("display_phone")]
        public DisplayPhone DisplayPhone;

        /// <summary>
        /// The email address for the payer. Maximum length is 127 characters.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email;
    }
}

