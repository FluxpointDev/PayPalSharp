


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Sets the balance for an agreement, by ID. In the JSON request body, specify the balance currency type and value.
    /// </summary>
    public class AgreementSetBalanceRequest : HttpRequest
    {
        public AgreementSetBalanceRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/set-balance?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementSetBalanceRequest RequestBody(MoneyTypeWithCurrencyCodeQualifiedValue Currency)
        {
            this.Body = Currency;
            return this;
        }
    }
}
