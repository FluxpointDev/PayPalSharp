




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Sends a reminder to the payer about an invoice, by ID. In the JSON request body, include a `notification` object that defines the subject of the reminder and other details.
    /// </summary>
    public class InvoiceRemindRequest : HttpRequest
    {
        public InvoiceRemindRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/remind?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceRemindRequest RequestBody(Notification Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
