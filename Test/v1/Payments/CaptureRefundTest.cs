using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class CaptureRefundTest
    {
        private RefundRequest buildRequestBody()
        {
            return new RefundRequest()
            {
                Amount = new Amount()
                {
                    Total = "10",
                    Currency = "USD"
                },
            };
        }

        [Fact]
        public async void TestCaptureRefundRequest()
        {
            var authCaptureResponse = await AuthorizationCaptureTest.CreateAuthCapture();
            var capture = authCaptureResponse.Result<Capture>();

            CaptureRefundRequest request = new CaptureRefundRequest(capture.Id);
            request.RequestBody(buildRequestBody());

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(201, (int) response.StatusCode);
            Assert.NotNull(response.Result<DetailedRefund>());
        }
    }
}
