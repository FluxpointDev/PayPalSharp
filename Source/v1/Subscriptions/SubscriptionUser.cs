using PayPal.v1.Payments;
using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{
    public class SubscriptionUser
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public SubscriptionUserName Name;

        [DataMember(Name = "email_address", EmitDefaultValue = false)]
        public string EmailAddress;

        [DataMember(Name = "payer_id", EmitDefaultValue = false)]
        public string PayerId;

        [DataMember(Name = "shipping_address", EmitDefaultValue = false)]
        public SubscriptionShippingAddress ShippingAddress;

        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime;
    }
    public class SubscriptionUserName
    {
        [DataMember(Name = "given_name", EmitDefaultValue = false)]
        public string GivenName;

        [DataMember(Name = "surname", EmitDefaultValue = false)]
        public string Surname;
    }
    public class SubscriptionShippingAddress
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "address", EmitDefaultValue = false)]
        public ShippingAddress Address;
    }
    public class SubscriptionShippingAddressName
    {
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName;
    }
}
