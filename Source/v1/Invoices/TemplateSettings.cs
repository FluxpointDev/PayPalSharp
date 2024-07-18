



// @data H4sIAAAAAAAC/6yRT0sDQQzF736KMOdFPPcmeBHxD1q8iLTpTrYTmM2MmZSySL+7bP+6rIJgj/OSSX4v79NNu0xu4qbU5ohG8EJmLMviKveKyriI9IBt3+Iqd0fd6XFDpVbOxkn6AYHADkPKfsilq9y1Kna7LVeVeyb0jxI7N2kwFuqFjxUr+aPwpCmTGlNxk7ff+eCeDD0ajkE9lxyxm2WlhpSkpgH6j+U/mIF2v/F8rhYpRUIZWwjsPckA+ygNUW/Fc41GBdaBLJCCBS7QMEUPXGD37b/Isopx876pjuTFlGU5Bt/unUn/+A4/kMe33tH2ZWiSAkp3MCAwPwQx628/3zasA9cBLEGLGeqkSiUn8SxL2KcLp3TLmcxffAEAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The template settings.
    /// </summary>

    public class TemplateSettings
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public TemplateSettings() { }

        /// <summary>
        /// The template settings metadata.
        /// </summary>
        [JsonPropertyName("display_preference")]
        public TemplateSettingsMetadata DisplayPreference;

        /// <summary>
        /// The field name for any field in `template_data` for which to map corresponding display preferences.
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName;
    }
}

