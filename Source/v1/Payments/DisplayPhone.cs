// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f

// @data H4sIAAAAAAAC/6yRP0/DMBTEdz6F5QUqxXECqEM2BB0qJEClYqmqynVeG0uObZ4dIgv1u6O0oX/owABj7nSX8+990ml0QAtaKu+0iAtXWQM0oW8ClVhqeBJ1Z9OEPkI8fDyAl6hcUNbQgk4rIE5EgEtPtgXENPUSMKUJvUMUcfeTLKETEOWz0ZEWK6E9dMJ7oxDKvfCC1gEGBZ4Ws/08H1CZ9fkuaRsTMC6kLeFk4w/jfO8stJbJSqCQAZCMXzN2kw+HLCd9lHTR+VUVgvMF5yV8gO6mpU5EJ3Qqbc1LKz1XJsAaRdfNS4UgA0fwgfc9rOvxfEDsioQjUL39V0am0XqT/Apqd5ATRHvpHI4y7JvC8T0TogyZjdJ8eNsryqyJ08KQlcVahAOutm1TFZpUmY6G5FM2Gd2zbZRdZ3mW52w8+Je3zzcXXwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Payments
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

