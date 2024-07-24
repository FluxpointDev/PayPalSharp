




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Invoices
{
    /// <summary>
    /// Generates a QR code for an invoice, by ID.<br/><br/>The QR code is a PNG image in [Base64-encoded](https://www.base64encode.org/) format that corresponds to the invoice ID. You can generate a QR code for an invoice and add it to a paper or PDF invoice. When a customer uses their mobile device to scan the QR code, he or she is redirected to the PayPal mobile payment flow where he or she can pay online with PayPal or a credit card.<br/><br/>Before you get a QR code, you must:<ol><li><p>[Create an invoice](#invoices_create). Specify `qrinvoice@paypal.com` as the recipient email address in the `billing_info` object. Use a customer email address only if you want to email the invoice.</p></li><li><p>[Send an invoice](#invoices_send) to move the invoice from a draft to payable state. If you specify `qrinvoice@paypal.com` as the recipient email address, the invoice is not emailed.</p></li></ol>
    /// </summary>
    public class InvoiceQrCodeRequest : HttpRequest
    {
        public InvoiceQrCodeRequest(string InvoiceId) : base("/v1/invoicing/invoices/{invoice_id}/qr-code?", HttpMethod.Get, typeof(QrCode))
        {
            try
            {
                this.Path = this.Path.Replace("{invoice_id}", Uri.EscapeDataString(Convert.ToString(InvoiceId)));
            }
            catch (IOException) { }

            this.ContentType = "application/json";
        }

        public InvoiceQrCodeRequest Action(string Action)
        {
            var strParams = Convert.ToString(Action);
            try
            {
                this.Path = $"{this.Path}action={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceQrCodeRequest Height(int Height)
        {
            var strParams = Convert.ToString(Height);
            try
            {
                this.Path = $"{this.Path}height={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public InvoiceQrCodeRequest Width(int Width)
        {
            var strParams = Convert.ToString(Width);
            try
            {
                this.Path = $"{this.Path}width={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
