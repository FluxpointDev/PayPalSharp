using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Sync.Test
{
    [Collection("PayPal Sync")]
    public class SearchGetTest
    {
        [Fact]
        public async void TestSearchMultipleTransactionsBetweenDates()
        {
            SearchGetRequest request = new SearchGetRequest()
                .StartDate("2018-01-22T00:00:00+00:00")
                .EndDate("2018-01-23T00:00:00+00:00");

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<SearchResponse>());

            SearchResponse searchResponse = response.Result<SearchResponse>();
            Assert.Equal(77, searchResponse.TotalItems);
            Assert.NotNull(searchResponse.TransactionDetails);
            Assert.Equal(searchResponse.TotalItems, searchResponse.TransactionDetails.Count);
        }

        [Fact]
        public async void TestSearchSpecificTransactionId()
        {
            var transactionId = "4LJ583775B2362642";
            SearchGetRequest request = new SearchGetRequest()
                .TransactionId(transactionId);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<SearchResponse>());

            SearchResponse searchResponse = response.Result<SearchResponse>();
            Assert.NotNull(searchResponse.TransactionDetails);
            Assert.Single(searchResponse.TransactionDetails);
            TransactionDetails transactionDetails = searchResponse.TransactionDetails[0];
            Assert.NotNull(transactionDetails);
            TransactionInformation transactionInformation = transactionDetails.TransactionInfo;
            Assert.NotNull(transactionInformation);
            Assert.Equal(transactionId, transactionInformation.TransactionId);
            Money money = transactionInformation.TransactionAmount;
            Assert.NotNull(money);
            Assert.Equal("USD", money.CurrencyCode);
            Assert.Equal("10.00", money.Value);
        }
    }
}
