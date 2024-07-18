


// @type request

using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Deletes an external refund, by invoice ID and transaction ID.
    /// </summary>
    public class InvoiceDeleteExternalRefundRequest : HttpRequest
    {
        public InvoiceDeleteExternalRefundRequest(string InvoiceId, string TransactionId) : base("/v1/invoicing/invoices/{invoice_id}/refund-records/{transaction_id}?", HttpMethod.Delete, typeof(void))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }
            try
            {
                this.Path = this.Path.Replace("{transaction_id}", Uri.EscapeDataString(Convert.ToString(TransactionId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

    }
}
