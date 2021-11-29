namespace Design_patterns.Facade.CrossCutting
{
    public interface IPayPalGateway
    {
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
        public string GetCardHashKey(string serviceKey, string creditCard);
        public string GetPayPalServiceKey(string apiKey, string encriptionKey);
    }
}
