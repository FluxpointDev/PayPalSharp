




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Lists invoices that match search criteria. In the JSON request body, include a `search` object that specifies the search criteria.
    /// </summary>
    public class InvoiceSearchRequest : HttpRequest
    {
        public InvoiceSearchRequest() : base("/v1/invoicing/search?", HttpMethod.Post, typeof(InvoiceList))
        {

            this.ContentType = "application/json";
        }

        public InvoiceSearchRequest RequestBody(Search Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
