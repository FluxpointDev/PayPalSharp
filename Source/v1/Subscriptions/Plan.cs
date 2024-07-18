using System;
using System.Runtime.Serialization;

namespace PayPal.v1.Subscriptions
{
    [DataContract]
    public class Plan
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id;

        [DataMember(Name = "product_id", EmitDefaultValue = false)]
        public string ProductId;

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name;

        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string StatusEnum;
    }

    [DataContract]
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
