


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Executes a billing agreement, by ID, after customer approval.
    /// </summary>
    public class AgreementExecuteRequest : HttpRequest
    {
        public AgreementExecuteRequest(string PaymentToken) : base("/v1/payments/billing-agreements/{payment_token}/agreement-execute?", HttpMethod.Post, typeof(Agreement))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_token}", Uri.EscapeDataString(Convert.ToString(PaymentToken)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
