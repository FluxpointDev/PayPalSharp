using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PayPal.v1
{
    /// <summary>
    /// A JSON patch object to apply partial updates to resources.
    /// </summary>
    [DataContract]
    public class JsonPatch<T>
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public JsonPatch() { }

        /// <summary>
        /// A JSON pointer to the location in the target document from which to move the value. Required for the `move` operation.
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From;

        /// <summary>
        /// REQUIRED
        /// The operation to complete.
        /// </summary>
        [DataMember(Name = "op", EmitDefaultValue = false)]
        public string Op;

        /// <summary>
        /// A JSON pointer to a location in the target document at which to complete the operation.
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path;

        /// <summary>
        /// The value to apply. The `remove` operation does not require a value.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public T Value;
    }
}
