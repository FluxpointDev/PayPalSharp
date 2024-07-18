




using System.Text.Json.Serialization;

namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// The ID of the plan on which this agreement is based.
    /// </summary>

    public class PlanWithId
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PlanWithId() { }

        /// <summary>
        /// The ID of the plan.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;
    }
}

