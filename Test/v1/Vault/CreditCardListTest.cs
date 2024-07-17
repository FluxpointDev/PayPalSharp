using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Vault.Test
{
    [Collection("Credit Card")]
    public class CreditCardListTest
    {

        [Fact]
        public async void TestCreditCardListRequest()
        {
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            CreditCardListRequest request = new CreditCardListRequest();

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<CreditCardList>());
        }
    }
}
