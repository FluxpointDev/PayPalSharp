using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class CaptureGetTest
    {

        [Fact]
        public async void TestCaptureGetRequest()
        {
            var authCaptureResponse = await AuthorizationCaptureTest.CreateAuthCapture();

            CaptureGetRequest request = new CaptureGetRequest(authCaptureResponse.Result<Capture>().Id);

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<Capture>());
        }
    }
}
