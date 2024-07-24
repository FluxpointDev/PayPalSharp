




using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// Updates information for a vaulted credit card, by ID. In the JSON request body, specify the values to update.
    /// </summary>
    public class CreditCardUpdateRequest<T> : HttpRequest
    {
        public CreditCardUpdateRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", new HttpMethod("PATCH"), typeof(CreditCard))
        {
            try
            {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public CreditCardUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
