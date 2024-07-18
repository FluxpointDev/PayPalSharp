




using System.Text.Json.Serialization;

namespace PayPal.v1.PaymentExperience
{
    /// <summary>
    /// A payment web experience profile.
    /// </summary>

    public class WebProfile
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public WebProfile() { }

        /// <summary>
        /// The flow configuration parameters.
        /// </summary>
        [JsonPropertyName("flow_config")]
        public FlowConfig FlowConfig;

        /// <summary>
        /// The ID of the web experience profile.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id;

        /// <summary>
        /// The input field customization parameters.
        /// </summary>
        [JsonPropertyName("input_fields")]
        public InputFields InputFields;

        /// <summary>
        /// REQUIRED
        /// The web experience profile name. Must be unique for a set of profiles for a merchant.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The style and presentation parameters.
        /// </summary>
        [JsonPropertyName("presentation")]
        public Presentation Presentation;

        /// <summary>
        /// Indicates whether the profile persists for three hours or permanently. To persist the profile permanently, set to `false`. To persist the profile for three hours, set to `true`.
        /// </summary>
        [JsonPropertyName("temporary")]
        public bool? Temporary;
    }
}

