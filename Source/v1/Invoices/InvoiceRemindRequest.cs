


// @type request
// @data H4sIAAAAAAAC/6xVwW7bMAy97ysInY0k24AdfCvSDc2GJtlS7LIVKWPRtTpbdCW6nVHk3wfZTho7LYpivQTRk0y+Rz5RD2qOBalYGXvHJqGRo8JYrSJ1Sj5xphTDVsVqRVZ7QGi3yYEwSEZQYk0OcMOVAFrookSwqWF2OoKZbU59XS3m4Oi2Ii+wYV1HYGySV5oA4cqymNQkGFJdAW9uKBGQDAU0pcaSb2L4qt3gtFnuiaDVwJKRA02CJvcjFanvFbl6iQ4LEnJexb8uI3VGqMkN0S/siiG2RMl62IO6qMtQJi/O2GsVqZ/oDG5y6pdvbULpvlHdwUd1vMgIZqc7Ed1XkLKD+8wkWSirJ6sPKh3knDiHdctgEqkfhHph81rFKeaeAnBbGUdaxeIqitTScUlODHkV2yrPt5ftGfLSBtnLmR+U/lhU6FRPTgccS6ICTQ7sYHW+gsN+vop9BxzSf7nySbJusvse00O0T/fEAgZCoQdsKZAu2BFMp3Erw49glkLNFXBhghGNh3JnBkgdF895GnvSwfjQSwk9xTx/TACotSPvG2OjALpwj5wMXDGCRbD1vfEUgS8pMWk9ZCMMuWlZ0nFw7kx1yMo36QKv0e9qMvmYbHJO/txWLNSs29/Ei2N73SJzFopbeHyIw4nWJsTE/Ch3SGJZwFdlyU5Id9nGw3R9f3x6rT8ae0cvmsSyUM8fHTCwRqBMvdH2v/4d8Nsw54RPXLVw6dfC64JckqGVHtknNvvEZ1aH9pKH+4yaWfg4RxIu652z2i51+nbR3ljicy3o5ndf2B47HimDef+WQ6WdidtwypdsPbVxAhypKVsh2w1KhWWZd1nHN74Zkmci5TlJxlrFarlYXaj2wVCxGt+9H7e319jr7h/58cPj67Ad7x/Yz39LSoT0SlAqP2VNKv4wmWzf/QMAAP//
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
