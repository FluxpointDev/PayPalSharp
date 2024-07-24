using BraintreeHttp;
using System;
using System.Net.Http.Headers;

namespace PayPal.Core
{
    public class PayPalHttpClient : CustomHttpClient
    {
        private string refreshToken;
        private IInjector gzipInjector;
        private IInjector authorizationInjector;

        public PayPalHttpClient(PayPalEnvironment environment) : this(environment, null)
        {
            BillingAgreements = new BillingAgreementEndpoints(this);
            BillingPlans = new BillingPlanEndpoints(this);
            CustomerDisputes = new CustomerDisputeEndpoints(this);
            Identity = new IdentityEndpoints(this);
            Invoices = new InvoiceEndpoints(this);
            Orders = new OrderEndpoints(this);
            Payments = new PaymentEndpoints(this);
            PaymentExperience = new PaymentExperienceEndpoints(this);
            Subscriptions = new SubscriptionEndpoints(this);
            Sync = new SyncEndpoints(this);
            Vault = new VaultEndpoints(this);
            Webhook = new WebhookEndpoints(this);
        }

        public PayPalHttpClient(PayPalEnvironment environment, string refreshToken) : base(environment)
        {
            this.refreshToken = refreshToken;
            gzipInjector = new GzipInjector();
            authorizationInjector = new AuthorizationInjector(this, environment, refreshToken);

            AddInjector(this.gzipInjector);
            AddInjector(this.authorizationInjector);

        }

        public BillingAgreementEndpoints BillingAgreements { get; internal set; }
        public BillingPlanEndpoints BillingPlans { get; internal set; }
        public CustomerDisputeEndpoints CustomerDisputes { get; internal set; }
        public IdentityEndpoints Identity { get; internal set; }
        public InvoiceEndpoints Invoices { get; internal set; }
        public OrderEndpoints Orders { get; internal set; }
        public PaymentEndpoints Payments { get; internal set; }
        public PaymentExperienceEndpoints PaymentExperience { get; internal set; }
        public SubscriptionEndpoints Subscriptions { get; internal set; }
        public SyncEndpoints Sync { get; internal set; }
        public VaultEndpoints Vault { get; internal set; }
        public WebhookEndpoints Webhook { get; internal set; }

        protected override string GetUserAgent()
        {
            return UserAgent.GetUserAgentHeader();
        }
    }
    internal class AuthorizationInjector : IInjector
    {
        private CustomHttpClient client;
        private PayPalEnvironment environment;
        private AccessToken accessToken;
        private string refreshToken;

        public AuthorizationInjector(CustomHttpClient client, PayPalEnvironment environment, string refreshToken)
        {
            this.environment = environment;
            this.client = client;
            this.refreshToken = refreshToken;
        }

        public void Inject(HttpRequest request)
        {

            if (!request.Headers.Contains("Authorization") && !(request is AccessTokenRequest || request is RefreshTokenRequest))
            {
                if (this.accessToken == null || this.accessToken.IsExpired())
                {
                    var accessTokenResponse = fetchAccessToken();
                    this.accessToken = accessTokenResponse.Result<AccessToken>();
                    Console.WriteLine("Access: " + this.accessToken.Token);
                }
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.Token);
            }
        }

        private HttpResponse fetchAccessToken()
        {
            AccessTokenRequest request = new AccessTokenRequest(environment, refreshToken);
            var executeTask = this.client.Execute(request);
            return executeTask.Result;
        }
    }
    internal class GzipInjector : IInjector
    {
        public void Inject(HttpRequest request)
        {
            request.Headers.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
        }
    }
}
