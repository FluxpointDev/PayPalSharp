


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Re-activates a suspended billing agreement, by ID. In the JSON request body, include an `agreement_state_descriptor` object with with a note that describes the reason for the re-activation and the agreement amount and currency.
    /// </summary>
    public class AgreementReActivateRequest : HttpRequest
    {
        public AgreementReActivateRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/re-activate?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementReActivateRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
