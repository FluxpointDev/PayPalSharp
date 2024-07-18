


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.BillingAgreements
{
    /// <summary>
    /// Lists transactions for an agreement, by ID. To filter the transactions that appear in the response, specify the optional start and end date query parameters.
    /// </summary>
    public class AgreementTransactionsRequest : HttpRequest
    {
        public AgreementTransactionsRequest(string AgreementId) : base("/v1/payments/billing-agreements/{agreement_id}/transactions?", HttpMethod.Get, typeof(AgreementTransactions))
        {
            try
            {
                this.Path = this.Path.Replace("{agreement_id}", Uri.EscapeDataString(Convert.ToString(AgreementId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public AgreementTransactionsRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try
            {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public AgreementTransactionsRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try
            {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
