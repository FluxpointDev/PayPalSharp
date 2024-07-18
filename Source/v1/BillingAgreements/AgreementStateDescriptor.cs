




using System.Text.Json.Serialization;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// A description of the current state of the agreement.
    /// </summary>

    public class AgreementStateDescriptor
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AgreementStateDescriptor() { }

        /// <summary>
        /// The reason for the agreement state change.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note;
    }
}

