using System.Threading.Tasks;
using System.Collections.Generic;
using BraintreeHttp;
using Xunit;
using PayPal.Test;

namespace PayPal.v1.Payments.Test
{
    [Collection("Payments")]
    public class PaymentCreateTest
    {
        private static Payment buildRequestBody(string intent, string paymentMethod = "credit_card", string invoiceNumber = null)
        {
            var body = new Payment()
            {
                Intent = intent,
                Transactions = new List<Transaction>() 
                {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = "10",
                            Currency = "USD"
                        }
                    }
                },
                RedirectUrls = new RedirectUrls() 
                {
                    CancelUrl = "https://example.com/cancel",
                    ReturnUrl = "https://example.com/return"
                }
            };

            if (invoiceNumber != null) 
            {
                body.Transactions[0].InvoiceNumber = invoiceNumber; 
            }

            if (paymentMethod.Equals("credit_card")) 
            {
                body.Payer = new Payer() 
                {
                    PaymentMethod = "credit_card",
                    FundingInstruments = new List<FundingInstrument>()
                    {
                        new FundingInstrument()
                        {
                            CreditCard = new CreditCard()
                            {
                                BillingAddress = new Address() 
                                {
                                    Line1 = "123 Townsend st",
                                    Line2 = "Suite 600",
                                    City = "San Francisco",
                                    State = "CA",
                                    CountryCode = "US",
                                    PostalCode = "94117"
                                },
                                Cvv2 = "111",
                                ExpireMonth = 1,
                                ExpireYear = 2020,
                                FirstName = "Joe",
                                LastName = "Shopper",
                                Type = "visa",
                                Number = "4422009910903049"
                            }
                        }
                    }
                };
            }
            else 
            {
                body.Payer = new Payer() 
                {
                    PaymentMethod = "paypal"
                };
            }

            return body;
        }

        public async static Task<HttpResponse> CreatePayment(string intent, string paymentMethod = "credit_card", string invoiceNumber = null) 
        {
            var request = new PaymentCreateRequest();

            request.RequestBody(buildRequestBody(intent, paymentMethod, invoiceNumber));
            return await TestHarness.client().Execute(request);
        }

        [Fact]
        public async void TestPaymentCreateRequest()
        {
            var response = await CreatePayment("sale", "paypal");

            Assert.Equal(201, (int) response.StatusCode);

            Assert.NotNull(response.Result<Payment>());

            Payment createdPayment = response.Result<Payment>();
            LinkDescriptionObject approvalLink = findApprovalLink(createdPayment.Links);

            // Redirect the customer to the approval URL for a PayPal payment
            Assert.NotNull(approvalLink);
            Assert.NotEmpty(approvalLink.Href);
        }

        private static LinkDescriptionObject findApprovalLink(List<LinkDescriptionObject> links) {
            foreach (var link in links) {
                if (link.Rel.Equals("approval_url")) {
                    return link;
                }
            }
            return null;
        }
    }
}
