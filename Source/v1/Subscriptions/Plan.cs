using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{

    public class Plan
    {
        [DataMember(Name = "id")]
        public string Id;

        [DataMember(Name = "product_id")]
        public string ProductId;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "status")]
        public string StatusEnum;
    }


    public enum PlanStatusType
    {
        [EnumMember(Value = "None")]
        None,

        [EnumMember(Value = "CREATED")]
        Created,

        [EnumMember(Value = "INACTIVE")]
        Inactive,

        [EnumMember(Value = "ACTIVE")]
        Active
    }
}
