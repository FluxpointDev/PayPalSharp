// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Executes a PayPal payment that the customer has approved. You can optionally update one or more transactions when you execute the payment.<blockquote><strong>Important:</strong> This call works only after a customer has approved the payment. For more information, learn about [PayPal payments](/docs/integration/direct/payments/paypal-payments/).</blockquote>
    /// </summary>
    public class PaymentExecuteRequest : HttpRequest
    {
        public PaymentExecuteRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}/execute?", HttpMethod.Post, typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }
        public PaymentExecuteRequest PaypalPartnerAttributionId(string PaypalPartnerAttributionId)
        {
            this.Headers.Add("PayPal-Partner-Attribution-Id", PaypalPartnerAttributionId);
            return this;
        }

        public PaymentExecuteRequest PaypalRequestId(string PaypalRequestId)
        {
            this.Headers.Add("PayPal-Request-Id", PaypalRequestId);
            return this;
        }


        public PaymentExecuteRequest RequestBody(PaymentExecution PaymentExecution)
        {
            this.Body = PaymentExecution;
            return this;
        }
    }
}
