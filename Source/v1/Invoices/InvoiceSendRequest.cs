


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Sends an invoice, by ID, to a customer.<blockquote><strong>Note:</strong> After you send an invoice, you cannot resend it.</blockquote><br/>Optionally, set the `notify_merchant` query parameter to also send the merchant an invoice update notification. Default is `true`.
    /// </summary>
    public class InvoiceSendRequest : HttpRequest
    {
        public InvoiceSendRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/send?", HttpMethod.Post, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceSendRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try
            {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
