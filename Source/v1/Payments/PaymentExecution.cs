// This class was generated on Mon, 09 Apr 2018 18:07:49 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using System.Collections.Generic;
using System.Text.Json.Serialization;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Executes a PayPal account-based payment with the `payer_id` obtained from the web approval URL.
    /// </summary>

    public class PaymentExecution
    {
        /// <summary>
	    /// Required default constructor
		/// </summary>
        public PaymentExecution() { }

        /// <summary>
        /// The ID of the payer that PayPal passes in the `return_url`.
        /// </summary>
        [JsonPropertyName("payer_id")]
        public string PayerId;

        /// <summary>
        /// An array of transaction details. Includes the amount and item details. For update and execute payment calls, the `transactions` object accepts only the `amount` object.
        /// </summary>
        [JsonPropertyName("transactions")]
        public List<CartBase> Transactions;
    }
}

