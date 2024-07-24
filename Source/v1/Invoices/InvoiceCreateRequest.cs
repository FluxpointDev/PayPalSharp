




using BraintreeHttp;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Creates a draft invoice. You can optionally create an invoice [template](/docs/api/invoicing/#templates). Then, when you create an invoice from a template, the invoice is populated with the predefined data that the source template contains. To move the invoice from a draft to payable state, you must [send the invoice](/docs/api/invoicing/#invoices_send). In the JSON request body, include invoice details including merchant information. The `invoice` object must include an `items` array.<blockquote><strong>Note:</strong> The merchant specified in an invoice must have a PayPal account in good standing.</blockquote>
    /// </summary>
    public class InvoiceCreateRequest : HttpRequest
    {
        public InvoiceCreateRequest() : base("/v1/invoicing/invoices?", HttpMethod.Post, typeof(Invoice))
        {

            this.ContentType = "application/json";
        }

        public InvoiceCreateRequest RequestBody(Invoice Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
