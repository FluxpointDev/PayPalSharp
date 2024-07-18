


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Bills the balance for an agreement, by ID. In the JSON request body, include an optional note that describes the reason for the billing action and the agreement amount and currency.
    /// </summary>
    public class AgreementBillBalanceRequest : HttpRequest
    {
        public AgreementBillBalanceRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/bill-balance?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementBillBalanceRequest RequestBody(AgreementStateDescriptor AgreementStateDescriptor)
        {
            this.Body = AgreementStateDescriptor;
            return this;
        }
    }
}
