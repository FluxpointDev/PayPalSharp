using System;
using BraintreeHttp;
using Xunit;
using PayPal.Test;
using System.Threading.Tasks;

namespace PayPal.v1.Vault.Test
{
    [Collection("Credit Card")]
    public class CreditCardGetTest
    {

        public static async Task<HttpResponse> getCreditCard(String id) {
            CreditCardGetRequest request = new CreditCardGetRequest(id);
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestCreditCardGetRequest()
        {
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            var expected = createResponse.Result<CreditCard>();

            HttpResponse response = await getCreditCard(expected.Id);

            Assert.Equal(200, (int) response.StatusCode);
            var creditCard = response.Result<CreditCard>();
            Assert.NotNull(creditCard);
            Assert.Equal(expected.Id, creditCard.Id);
            Assert.Equal(expected.FirstName, creditCard.FirstName);
            Assert.Equal(expected.LastName, creditCard.LastName);
            Assert.Equal(expected.BillingAddress.City, creditCard.BillingAddress.City);
        }
    }
}
