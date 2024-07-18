


// @type request

using BraintreeHttp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Updates details of a billing agreement, by ID. Details include the description, shipping address, start date, and so on.
    /// </summary>
    public class AgreementUpdateRequest<T> : HttpRequest
    {
        public AgreementUpdateRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}?", new HttpMethod("PATCH"), typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementUpdateRequest<T> RequestBody(List<JsonPatch<T>> PatchRequest)
        {
            this.Body = PatchRequest;
            return this;
        }
    }
}
