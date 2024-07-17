using System.Runtime.Serialization;

namespace PayPal.v1
{
    /// <summary>
    /// The currency and amount for a transaction.
    /// </summary>
    [DataContract]
    public class Currency
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Currency() { }

        /// <summary>
        /// The [three-character ISO-4217 currency code](/docs/integration/direct/rest/currency-codes/). PayPal does not support all currencies.
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string CurrencyCode;

        /// <summary>
        /// REQUIRED
        /// The amount. Includes the specified number of digits after decimal separator for the [ISO-4217 currency code](https://en.wikipedia.org/wiki/ISO_4217#Active_codes).
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value;
    }
}
