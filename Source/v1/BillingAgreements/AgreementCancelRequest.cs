


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Cancels a billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with an optional note that describes the reason for the cancellation and the agreement amount and currency.
    /// </summary>
    public class AgreementCancelRequest : HttpRequest
    {
        public AgreementCancelRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementCancelRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
