



// @data H4sIAAAAAAAC/6yRT2vjMBTE7/sphC67Acuyd5ccfFs2OYRCG9LQSwhFkV9igSypT3KNKPnuRY2bP82hh/boGWY8+r0XuowOaEUnyjstIpk31gDN6INAJTYabkWbbJrRG4injwl4icoFZQ2t6LIB4kQE+OmJSwXEdO0GMKcZ/Yco4uEnRUYXIOo7oyOttkJ7SMJTpxDqozBH6wCDAk+r1XGeD6jM7nqXtJ0JGB+lreFi4wfjeu8q9JbJRqCQAZDM7gv2pxyPWUmGKEnR9a8mBOcrzmt4Bp2m5U5EJ3QubctrKz1XJsAORermtUKQgSP4wIcelno8HxG7JeEM1GB/lZHptN5nn4I6HOQC0VG6hqMMe6dwfs+MKENW07wc/x0UZXbEaWHI1mIrwglX3/e5Cl2uTKIh+ZItpv/ZW5T9LsqiLNls9C1vX+9/vAIAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Orders
{
    /// <summary>
    /// The payee's phone number.
    /// </summary>

    public class DisplayPhone
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public DisplayPhone() { }

        /// <summary>
        /// The [two-character IS0-3166-1 country code](https://developer.paypal.com/docs/integration/direct/rest/country-codes/) of the payee's country.
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode;

        /// <summary>
        /// The in-country phone number, in [E.164 numbering plan format](https://www.itu.int/rec/T-REC-E.164-201011-I).
        /// </summary>
        [JsonPropertyName("number")]
        public string Number;
    }
}

