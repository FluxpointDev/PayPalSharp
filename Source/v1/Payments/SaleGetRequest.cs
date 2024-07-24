// This class was generated on Mon, 09 Apr 2018 18:07:50 UTC by version 0.1.0-dev+291f3f

// @version 0.1.0-dev+291f3f


using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Shows details for a sale, by ID. Returns only sales that were created through the REST API.
    /// </summary>
    public class SaleGetRequest : HttpRequest
    {
        public SaleGetRequest(string SaleId) : base("/v1/payments/sale/{sale_id}?", HttpMethod.Get, typeof(Sale))
        {
            try
            {
                this.Path = this.Path.Replace("{sale_id}", Uri.EscapeDataString(Convert.ToString(SaleId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
