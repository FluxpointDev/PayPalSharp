// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f of Braintree SDK Generator
// PaymentUpdateRequest.cs
// @version 0.1.0-dev+291f3f
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Partially updates a payment, by ID. You can update the amount, shipping address, invoice ID, and custom data. You cannot update a payment after the payment executes. <blockquote><strong>Note: </strong>TPP Clients (Third Party Providers in the context of PSD2 regulation) are restricted from patching amount once authorized.</blockquote>
    /// </summary>
    public class PaymentUpdateRequest<T> : HttpRequest
    {
        public PaymentUpdateRequest(string PaymentId) : base("/v1/payments/payment/{payment_id}?", new HttpMethod("PATCH"), typeof(Payment))
        {
            try {
                this.Path = this.Path.Replace("{payment_id}", Uri.EscapeDataString(Convert.ToString(PaymentId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public PaymentUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
