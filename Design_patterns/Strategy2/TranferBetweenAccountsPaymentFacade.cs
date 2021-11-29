using System;
using System.Linq;

namespace Design_patterns.Strategy2
{
    public class TranferBetweenAccountsPaymentFacade : ITranferBetweenAccountsPaymentFacade
    {
        public string TransactionHash(decimal transactionValue)
        {
            var accountValue = new Random().Next(1000);

            if(accountValue >= transactionValue)
                return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(x => x[new Random().Next(x.Length)]).ToArray());

            return string.Empty;
        }
    }
}
