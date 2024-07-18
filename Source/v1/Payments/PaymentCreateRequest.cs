// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Creates a sale, an authorized payment to be captured later, or an order. To create a sale, authorization, or order, include the payment details in the JSON request body. Set the `intent` to `sale`, `authorize`, or `order`. <blockquote><strong>Note: </strong>TPP Clients (Third Party Providers in the context of PSD2 regulation) are restricted from using <code>authorize</code> and <code>order</code> intents.</blockquote> Include payer, transaction details, and, for PayPal payments only, redirect URLs. The combination of the `payment_method` and `funding_instrument` determines the type of payment that is created. For more information, see [Payments REST API](/docs/integration/direct/payments/).<blockquote><strong>Note:</strong> Authorizations are guaranteed for up to three days, though you can attempt to capture an authorization for up to 29 days. After the three-day honor period authorization expires, you can [reauthorize](#authorization_reauthorize) the payment.</blockquote>
    /// </summary>
    public class PaymentCreateRequest : HttpRequest
    {
        public PaymentCreateRequest() : base("/v1/payments/payment?", HttpMethod.Post, typeof(Payment))
        {

            this.ContentType = "application/json";
        }
        public PaymentCreateRequest PaypalPartnerAttributionId(string PaypalPartnerAttributionId)
        {
            this.Headers.Add("PayPal-Partner-Attribution-Id", PaypalPartnerAttributionId);
            return this;
        }


        public PaymentCreateRequest RequestBody(Payment Payment)
        {
            this.Body = Payment;
            return this;
        }
    }
}
