




using System.Text.Json.Serialization;

namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// The style and presentation parameters.
    /// </summary>

    public class Presentation
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Presentation() { }

        /// <summary>
        /// A label that overrides the business name in the PayPal account on the PayPal pages. Character length and limitations: 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("brand_name")]
        public string BrandName;

        /// <summary>
        /// The locale of pages that the PayPal payment experience displays. A valid value is `AU`, `AT`, `BE`, `BR`, `CA`, `CH`, `CN`, `DE`, `ES`, `GB`, `FR`, `IT`, `NL`, `PL`, `PT`, `RU`, or `US`. A 5-character code is also valid for languages in these countries: `da_DK`, `he_IL`, `id_ID`, `ja_JP`, `no_NO`, `pt_BR`, `ru_RU`, `sv_SE`, `th_TH`, `zh_CN`, `zh_HK`, or `zh_TW`.
        /// </summary>
        [JsonPropertyName("locale_code")]
        public string LocaleCode;

        /// <summary>
        /// A URL to the logo image. A valid media type is `.gif`, `.jpg`, or `.png`. The image's maximum width is 190 pixels and maximum height is 60 pixels. PayPal crops images that are larger. PayPal places your logo image at the top of the cart review area. PayPal recommends that you store the image on a secure (HTTPS) server. Otherwise, web browsers display a message that checkout pages contain non-secure items. Character length and limitations: 127 single-byte alphanumeric characters.
        /// </summary>
        [JsonPropertyName("logo_image")]
        public string LogoImage;
    }
}

