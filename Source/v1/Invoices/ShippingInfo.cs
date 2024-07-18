



// @data H4sIAAAAAAAC/7yVT2/UPBDG7++nGPm9UCnK0uW2t/JPQiBa0cIBVFWzyWQz4NiuPSlEqN8dOZvs1k0RW1jtLXlm7Pye8WT8U110jtRCndfsHJsVvDGVVZn6hJ5xqek9NjGsMvWWuu3LSwqFZydsjVqoi5ogjBuwqaxvMIagsh6kJmBzY7kg8FSwYzKSq0ydeI/d+vNPM/WBsDw1ulOLCnWgKFy37KncCGfeOvLCFNTiywb8pCw9hTBFxk1gS77VUgPPMRAMO4FdfqVCoA1UAgZYstbR17AW2ACCw64hI2A90A8hU1LZm92Ucdhsfz6DeDarqc2CpUs8DkJq8AVLBwYbehSQ+PYej2m1vs3+DGVbI767KmxJKVwaSCHnoEmEPAxZELMOA6zZ0HFCOiop4js2BMdgq76tx455QqscTNssyWcQxBNJBiTF0eHg5xP4+QT+tH9ADTEM8wddhJaFMkAn8H/vIT/61x7e0YWrrUmbZVRSF2dRHaodf8ZX+fH8GaxnzqFQbRDU0+5O9RT7M7u+n/uRcd3yDeo4QDhAG1rUugM/kPWDZP0LMAWQGgVqvKF4WE0Or60HzUHi8d3LKi0YOySvWfpPBnCa4oTzVJEHsVCLuMVsRib/zt/YUcmYW7+axbfZ2dbFgeoZBCWt5Kj8dkCU1Jfp4zn0qSEDNGXfzneKGzOs1HSnnHtxdLmDp2Ub2FAIV3HqJt7uR6Z36eS6hMI2Dk0H49rHz/K/P52KfZCpjUTexUO/4JDgGh/ivqvugh3z90d9efvfLwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The shipping information for the invoice recipient.
    /// </summary>

    public class ShippingInfo
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public ShippingInfo() { }

        /// <summary>
        /// Base Address object used as billing address in a payment or extended for Shipping Address.
        /// </summary>
        [JsonPropertyName("address")]
        public Address Address;

        /// <summary>
        /// The invoice recipient company business name.
        /// </summary>
        [JsonPropertyName("business_name")]
        public string BusinessName;

        /// <summary>
        /// The invoice recipient first name.
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName;

        /// <summary>
        /// The invoice recipient last name.
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName;
    }
}

