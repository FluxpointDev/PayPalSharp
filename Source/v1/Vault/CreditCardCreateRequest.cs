




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// Stores credit card details in the PayPal vault. To use the vaulted card to make a payment, specify this ID as the `credit_card_id` in a [`credit_card_token`](/docs/api/payments/#definition-credit_card_token) object. If you include a `payer_id` when you store the credit card, you must also include that ID as the `external_customer_id` in the `credit_card_token` object.<br/>You can also use the ID of the vaulted credit card to show details for, update, or delete the vaulted card.
    /// </summary>
    public class CreditCardCreateRequest : HttpRequest
    {
        public CreditCardCreateRequest() : base("/v1/vault/credit-cards?", HttpMethod.Post, typeof(CreditCard))
        {

            this.ContentType = "application/json";
        }

        public CreditCardCreateRequest RequestBody(CreditCard CreditCard)
        {
            this.Body = CreditCard;
            return this;
        }
    }
}
