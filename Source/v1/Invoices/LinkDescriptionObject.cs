



// @data H4sIAAAAAAAC/7yUz2vbThDF79+/YtjTt6BGoZQefDP9QaChNrbaS8hhpB1lt1nvbnZGtKLkfy8rObZVQUtL8FFvtPb7zHvaH6rqI6mFurb+Ht4RN8lGscHDqv5KjahCfcFksXb0CXf5RVWoj9QfH07OqIWqDMHN1bJ6v1puwVl/z7f/lzo0XGK0pUGhgPxyGJQvIJFDIQ0SQAxBooeOWC5UoZYpYT9auyzUhlCvvOvVokXHlIWHzibSB2GdQqQkllgtbg5QLMn6uzkD+WZ44xTlqM2JdqQtgvSRwHr4Zmxjsmfu6p0V0CiY9WdE8J1zj8UfOUyidgKxF+YEnzfXENq9xXHppyllmo4HOu5qzhBeoEHn+K9QJHX/RjJseJbJqfq7VApABk2t9aSh7mHz4S28unz9pgAxKKCHozXxwD/yYrqjc8W0IzFB/0K2l+ZYV1W1hnE+1Cn/O7QhTcLL0ZzJfSI3sT4+z30P1vLNsf+axxVDIg5dauipfnn9F7A1oXMaaoLgDyP6LuQ16TGi4+/1kSbxrteI29xVIxJ5UZYxIvJ4zbCg15g0l6aPlIaOnKXBYsVN2/ukzFc1VjCPnyXD28f/fgIAAP//
using System.Text.Json.Serialization;

namespace PayPal.v1.Invoices
{
    /// <summary>
    /// The [HATEOAS links](/docs/api/hateoas-links/) related to the request.
    /// </summary>

    public class InvoiceLinkDescriptionObject : LinkDescriptionObject
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public InvoiceLinkDescriptionObject() { }

        /// <summary>
        /// The media type in which to submit data in the request.
        /// </summary>
        [JsonPropertyName("encType")]
        public string EncType;

        /// <summary>
        /// The media type, as defined by RFC 2046, that describes the link target.
        /// </summary>
        [JsonPropertyName("mediaType")]
        public string MediaType;

        /// <summary>
        /// The link title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title;
    }
}

