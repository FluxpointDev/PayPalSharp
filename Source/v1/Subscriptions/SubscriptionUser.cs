using PayPal.v1.Payments;
using System.Globalization;
using System;
using System.Text.Json.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class SubscriptionUser
    {
        [JsonPropertyName("name")]
        public SubscriptionUserName Name;

        [JsonPropertyName("email_address")]
        public string EmailAddress;

        [JsonPropertyName("payer_id")]
        public string PayerId;

        [JsonPropertyName("shipping_address")]
        public SubscriptionShippingAddress ShippingAddress;

        [JsonPropertyName("create_time")]
        public string CreateTimeFormat;

        [JsonIgnore]
        public DateTime CreatedDate => DateTime.Parse(CreateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
    }
    public class SubscriptionUserName
    {
        [JsonPropertyName("given_name")]
        public string GivenName;

        [JsonPropertyName("surname")]
        public string Surname;
    }
    public class SubscriptionShippingAddress
    {
        [JsonPropertyName("name")]
        public string Name;

        [JsonPropertyName("address")]
        public ShippingAddress Address;
    }
    public class SubscriptionShippingAddressName
    {
        [JsonPropertyName("full_name")]
        public string FullName;
    }
}
