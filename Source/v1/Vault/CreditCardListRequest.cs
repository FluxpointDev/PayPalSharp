




using BraintreeHttp;
using System;
using System.IO;
using System.Net.Http;


namespace PayPal.v1.Vault
{
    /// <summary>
    /// Lists vaulted credit cards. To filter the cards in the response, specify one or more optional query parameters.
    /// </summary>
    public class CreditCardListRequest : HttpRequest
    {
        public CreditCardListRequest() : base("/v1/vault/credit-cards?", HttpMethod.Get, typeof(CreditCardList))
        {

            this.ContentType = "application/json";
        }

        public CreditCardListRequest EndTime(string EndTime)
        {
            var strParams = Convert.ToString(EndTime);
            try
            {
                this.Path = $"{this.Path}end_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest ExternalCardId(string ExternalCardId)
        {
            var strParams = Convert.ToString(ExternalCardId);
            try
            {
                this.Path = $"{this.Path}external_card_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest ExternalCustomerId(string ExternalCustomerId)
        {
            var strParams = Convert.ToString(ExternalCustomerId);
            try
            {
                this.Path = $"{this.Path}external_customer_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest MerchantId(string MerchantId)
        {
            var strParams = Convert.ToString(MerchantId);
            try
            {
                this.Path = $"{this.Path}merchant_id={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest Page(int Page)
        {
            var strParams = Convert.ToString(Page);
            try
            {
                this.Path = $"{this.Path}page={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest PageSize(int PageSize)
        {
            var strParams = Convert.ToString(PageSize);
            try
            {
                this.Path = $"{this.Path}page_size={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest SortBy(string SortBy)
        {
            var strParams = Convert.ToString(SortBy);
            try
            {
                this.Path = $"{this.Path}sort_by={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest SortOrder(string SortOrder)
        {
            var strParams = Convert.ToString(SortOrder);
            try
            {
                this.Path = $"{this.Path}sort_order={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest StartTime(string StartTime)
        {
            var strParams = Convert.ToString(StartTime);
            try
            {
                this.Path = $"{this.Path}start_time={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


        public CreditCardListRequest TotalRequired(bool TotalRequired)
        {
            var strParams = Convert.ToString(TotalRequired);
            try
            {
                this.Path = $"{this.Path}total_required={Uri.EscapeDataString(strParams)}&";
            }
            catch (IOException) { }
            return this;
        }


    }
}
