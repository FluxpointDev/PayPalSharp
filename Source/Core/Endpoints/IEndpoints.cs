namespace PayPal.Core
{
    public class IEndpoints
    {
        internal IEndpoints(PayPalHttpClient client)
        {
            Client = client;
        }

        internal PayPalHttpClient Client { get; set; }
    }
}
