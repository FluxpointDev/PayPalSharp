




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// Deletes a vaulted credit card, by ID.
    /// </summary>
    public class CreditCardDeleteRequest : HttpRequest
    {
        public CreditCardDeleteRequest(string CreditCardId) : base("/v1/vault/credit-cards/{credit_card_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{credit_card_id}", Uri.EscapeDataString(Convert.ToString(CreditCardId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
