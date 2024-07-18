using PayPal.v1.Payments;
using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class SubscriptionUser
    {
        [DataMember(Name = "name")]
        public SubscriptionUserName Name;

        [DataMember(Name = "email_address")]
        public string EmailAddress;

        [DataMember(Name = "payer_id")]
        public string PayerId;

        [DataMember(Name = "shipping_address")]
        public SubscriptionShippingAddress ShippingAddress;

        [DataMember(Name = "create_time")]
        public string CreateTime;
    }
    public class SubscriptionUserName
    {
        [DataMember(Name = "given_name")]
        public string GivenName;

        [DataMember(Name = "surname")]
        public string Surname;
    }
    public class SubscriptionShippingAddress
    {
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "address")]
        public ShippingAddress Address;
    }
    public class SubscriptionShippingAddressName
    {
        [DataMember(Name = "full_name")]
        public string FullName;
    }
}
