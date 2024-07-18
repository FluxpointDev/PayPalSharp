



// @data H4sIAAAAAAAC/7yTwW7UMBCG7zzFyCeQomgLSCh7g/ZSIbUIql4Qh4k9aQc5thmPUSPEuyPvbjekWwkQq54i/4mj75vf/mGupkRmba7wzjTmGoWx93SBYw1NY97TNC/OKFvhpBzDdgtwGKKMWJPWNOatCE7bP64a85HQXQY/mfWAPlMNvhUWcvvgg8REokzZrD/vWU6LCAU7HQLhGEvQBdY+WsK9w0wQ+69kFYYogN7DwAGDZfTwHX0hEPKo5GBg8i7D8x49BksNJJxGCgquUAOktn1xNLeswuHm0MzunE+jo4WfnYexNHwFnlRJ4P4LsNERYAZHAwdy0E9w/ukSXr88efO/5YTi/c/mjxabuS7w75Ml+7Y0KAk0wgU4vmEFHKqN3hI4sjyiz5ApoaDW/mYtDnutTbV1B6YkMQmj0nIe/ySuUh7z/vIX5uwW2pvlg+tyW09cjkUswfnZEzUS6uN3sl1wyKZ4B/XlMSY2c4Uy9iSHXInE0oOrPGeP0wkqtXCNnt3uBnOGQeIIq3a1OqlnqevaruuOU/qzXwAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Tax information.
    /// </summary>

    public class Tax
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public Tax() { }

        /// <summary>
        /// Base object for all financial value related fields (balance, payment due, etc.)
        /// </summary>
        [JsonPropertyName("amount")]
        public Currency Amount;

        /// <summary>
        /// The resource ID.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// REQUIRED
        /// The tax name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// REQUIRED
        /// The tax rate. Valid value is from 0.001 to 99.999.
        /// </summary>
        [JsonPropertyName("percent")]
        public double? Percent;
    }
}

