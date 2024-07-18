


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Shows details for an invoice, by ID.
    /// </summary>
    public class InvoiceGetRequest : HttpRequest
    {
        public InvoiceGetRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Get, typeof(Invoice))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
