



// @data H4sIAAAAAAAC/6zPQUs0MQwG4Pv3K0LO5cPz3BbEi6KyrF7EQ3aasYFOOmYyLoPsf5e6sq6M4EFPJW/L2yevuJkHxgYvJDOs3KlNPatjwHsyoW3ma+rrAwx4yfPncM5jazK4FMUGN4mhqxX0XsERvAApiL4UaRmKgXM/ZHL+jwFXZjQffj4LuGaKN5pnbDrKI9fgeRLjeAxurQxsLjxi83A0j26iT0uq1uOU+xEsyfUCSgeeTuR1j98idcp5H36UTpa/QA/z0nm3vvqWGWCXpE3QksKWIZad5kKR45/4H/f/3gAAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The file attached to an invoice or template.
    /// </summary>

    public class FileAttachment
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public FileAttachment() { }

        /// <summary>
        /// The name of the attached file.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name;

        /// <summary>
        /// The URL of the attached file, which can be downloaded.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url;
    }
}

