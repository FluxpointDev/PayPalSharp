using System.Runtime.Serialization;

namespace PayPal.v1
{
    /// <summary>
    /// A JSON patch object to apply partial updates to resources.
    /// </summary>

    public class JsonPatch<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public JsonPatch() { }

        /// <summary>
        /// A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name = "from")]
        public string From;

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name = "op")]
        public string Op;

        /// <summary>
        /// A JSON pointer to a location in the target document at which to complete the operation.
        /// </summary>
        [DataMember(Name = "path")]
        public string Path;

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name = "value")]
        public T Value;
    }
}
