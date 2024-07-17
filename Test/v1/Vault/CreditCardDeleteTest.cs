using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Vault.Test
{
    [Collection("Credit Card")]
    public class CreditCardDeleteTest
    {

        [Fact]
        public async void TestCreditCardDeleteRequest()
        {
            HttpResponse createResponse = await CreditCardCreateTest.createCreditCard();
            var expected = createResponse.Result<CreditCard>();
            CreditCardDeleteRequest request = new CreditCardDeleteRequest(expected.Id);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(204, (int) response.StatusCode);
        }
    }
}
