using System.IO;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;


namespace PayPal.v1.CustomerDisputes.Test
{
    [Collection("Customer Disputes")]
    public class DisputeAppealTest
    {
        [Fact(Skip = "This test requires a dispute in the correct state.")]
        public async void TestDisputeAppealRequest()
        {
            DisputeAppealRequest request = new DisputeAppealRequest("PP-000-042-635-183");

            var evidenceInput = new Evidence()
            {
                EvidenceType = "OTHER",
                Notes = "Notes"
            };
            var evidencePart = new JsonPartContent("input", evidenceInput);

            request.Body = new Dictionary<string, object>()
            {
                {"input", evidencePart},
                {"file1", File.Open("../../../../Test/v1/CustomerDisputes/fileupload_test_binary_3.jpg", FileMode.Open)}
            };

            HttpResponse response = await TestHarness.client().Execute(request);
            Assert.Equal(200, (int) response.StatusCode);
            Assert.NotNull(response.Result<SubsequentActions>());
        }
    }
}
