// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Shows details for a payment, by ID, that has yet to complete. For example, shows details for a payment that was created, approved, or failed.
    /// </summary>
    public class PaymentGetRequest : HttpRequest
    {
        public PaymentGetRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", HttpMethod.Get, typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
