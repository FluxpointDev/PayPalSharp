


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Suspends a billing agreement, by ID.
    /// </summary>
    public class AgreementSuspendRequest : HttpRequest
    {
        public AgreementSuspendRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/suspend?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementSuspendRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
