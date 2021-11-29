using System;
using System.Linq;

namespace Design_patterns.Facade.CrossCutting
{
    public class PayPalGateway : IPayPalGateway
    {
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public string GetCardHashKey(string serviceKey, string creditCard)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }

        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());
        }
    }
}
