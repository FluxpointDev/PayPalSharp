


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Cancels a sent invoice, by ID, and, optionally, sends a notification about the cancellation to the payer, merchant, and Cc: emails.
    /// </summary>
    public class InvoiceCancelRequest : HttpRequest
    {
        public InvoiceCancelRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/cancel?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceCancelRequest RequestBody(CancelNotification Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
