


// @type request

using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Generates the next invoice number that is available to the merchant.
    /// </summary>
    public class InvoiceNextInvoiceNumberRequest : HttpRequest
    {
        public InvoiceNextInvoiceNumberRequest() : base("/v1/invoicing/invoices/next-invoice-number?", HttpMethod.Post, typeof(InvoiceNumber))
        {

            this.ContentType = "application/json";
        }

    }
}
