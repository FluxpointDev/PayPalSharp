

// @version 0.1.0-dev+291f3f


using System.Text.Json.Serialization;

namespace PayPal.v1.CustomerDisputes
{
    /// <summary>
    /// The non-portable additional address details that are sometimes needed for compliance, risk, or other scenarios where fine-grain address information might be needed. Not portable with common third party and opensource. Redundant with core fields. For example, `address_portable.address_line_1` is usually a combination of `address_details.street_number` and `street_name` and `street_type`.
    /// </summary>

    public class AddressDetails
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public AddressDetails() { }

        /// <summary>
        /// A named locations that represents the premise. Usually a building name or number or collection of buildings with a common name or number. For example, <code>Craven House</code>.
        /// </summary>
        [JsonPropertyName("building_name")]
        public string BuildingName;

        /// <summary>
        /// The delivery service. Post office box, bag number, or post office name.
        /// </summary>
        [JsonPropertyName("delivery_service")]
        public string DeliveryService;

        /// <summary>
        /// The street name. Just `Drury` in `Drury Lane`.
        /// </summary>
        [JsonPropertyName("street_name")]
        public string StreetName;

        /// <summary>
        /// The street number.
        /// </summary>
        [JsonPropertyName("street_number")]
        public string StreetNumber;

        /// <summary>
        /// The street type of the address. For example, `Street`, `Lane`, `Boulevard`, `Court`, and so on.
        /// </summary>
        [JsonPropertyName("street_type")]
        public string StreetType;

        /// <summary>
        /// The first-order entity below a named building or location that represents the sub-premise. Usually a single building within a collection of buildings with a common name. Can be a flat, storey, floor, room, or apartment.
        /// </summary>
        [JsonPropertyName("sub_building")]
        public string SubBuilding;
    }
}

