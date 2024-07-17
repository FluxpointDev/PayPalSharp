using Xunit;
using System.Linq;
using PayPal.v1.Payments.Test;

namespace PayPal.Core.Test
{
    [Collection("Core")]
    public class HttpRequestTest
    {

        [Fact]
        public async void TestHeadersAreCaseInsensitive()
        {
            var response = await PaymentCreateTest.CreatePayment("sale");

            var debugId = response.Headers.GetValues("paypal-debug-id").FirstOrDefault();
            var camelCasedDebugId = response.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

            Assert.NotNull(debugId);
            Assert.NotNull(camelCasedDebugId);
            Assert.Equal(debugId, camelCasedDebugId);
        }
    }
}
