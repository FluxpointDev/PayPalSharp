




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Sync
{
    /// <summary>
    /// Shows details for a transaction, by transaction date or transaction ID. To filter the transaction that appears in the response, specify one or more optional query parameters.<blockquote><strong>Note:</strong> If you specify query parameters, the `ending_balance` field does not contain a value.</blockquote><br/>To limit, or <em>page</em>, the data that appears in the response, use these query parameters:<table><thead><tr><th>Parameter</th><th>Type</th><th>Description</th></tr></thead><tbody><tr><td><code>page</code></td><td>integer</td><td>The zero-relative start index of the entire list of items that are returned in the response. So, the combination of <code>page=1</code> and <code>page_size=20</code> returns the first 20 items.</td></tr><tr><td><code>page_size</code></td><td>integer</td><td>The number of items to return in the response.</td></tr></tbody></table>
    /// </summary>
    public class SearchGetRequest : HttpRequest
    {
        public SearchGetRequest() : base("/v1/reporting/transactions?", HttpMethod.Get, typeof(SearchResponse))
        {

            this.ContentType = "application/json";
        }

        public SearchGetRequest BalanceAffectingRecordsOnly(string BalanceAffectingRecordsOnly)
        {
            var strParams = Convert.ToString(BalanceAffectingRecordsOnly);
            try
            {
                this.Path = $"{this.Path}balance_affecting_records_only={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest EndDate(string EndDate)
        {
            var strParams = Convert.ToString(EndDate);
            try
            {
                this.Path = $"{this.Path}end_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest Fields(string Fields)
        {
            var strParams = Convert.ToString(Fields);
            try
            {
                this.Path = $"{this.Path}fields={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest PaymentInstrumentType(string PaymentInstrumentType)
        {
            var strParams = Convert.ToString(PaymentInstrumentType);
            try
            {
                this.Path = $"{this.Path}payment_instrument_type={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest StartDate(string StartDate)
        {
            var strParams = Convert.ToString(StartDate);
            try
            {
                this.Path = $"{this.Path}start_date={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest StoreId(string StoreId)
        {
            var strParams = Convert.ToString(StoreId);
            try
            {
                this.Path = $"{this.Path}store_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TerminalId(string TerminalId)
        {
            var strParams = Convert.ToString(TerminalId);
            try
            {
                this.Path = $"{this.Path}terminal_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TransactionAmount(string TransactionAmount)
        {
            var strParams = Convert.ToString(TransactionAmount);
            try
            {
                this.Path = $"{this.Path}transaction_amount={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TransactionCurrency(string TransactionCurrency)
        {
            var strParams = Convert.ToString(TransactionCurrency);
            try
            {
                this.Path = $"{this.Path}transaction_currency={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TransactionId(string TransactionId)
        {
            var strParams = Convert.ToString(TransactionId);
            try
            {
                this.Path = $"{this.Path}transaction_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TransactionStatus(string TransactionStatus)
        {
            var strParams = Convert.ToString(TransactionStatus);
            try
            {
                this.Path = $"{this.Path}transaction_status={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public SearchGetRequest TransactionType(string TransactionType)
        {
            var strParams = Convert.ToString(TransactionType);
            try
            {
                this.Path = $"{this.Path}transaction_type={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
