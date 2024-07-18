


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Fully updates an invoice, by ID. In the JSON request body, include a complete `invoice` object. This call does not support partial updates.
    /// </summary>
    public class InvoiceUpdateRequest : HttpRequest
    {
        public InvoiceUpdateRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}?", HttpMethod.Put, typeof(Invoice))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceUpdateRequest NotifyMerchant(bool NotifyMerchant)
        {
            var strParams = Convert.ToString(NotifyMerchant);
            try
            {
                this.Path = $"{this.Path}notify_merchant={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceUpdateRequest RequestBody(Invoice Body)
        {
            this.Body = Body;
            return this;
        }
    }
}
