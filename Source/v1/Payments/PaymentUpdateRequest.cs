// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f
// @type request

using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Partially updates a payment, by ID. You can update the amount, shipping address, invoice ID, and custom data. You cannot update a payment after the payment executes. <blockquote><strong>Note: </strong>TPP Clients (Third Party Providers in the context of PSD2 regulation) are restricted from patching amount once authorized.</blockquote>
    /// </summary>
    public class PaymentUpdateRequest<T> : HttpRequest
    {
        public PaymentUpdateRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", new HttpMethod("PATCH"), typeof(Payment))
        {
            try
            {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public PaymentUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
