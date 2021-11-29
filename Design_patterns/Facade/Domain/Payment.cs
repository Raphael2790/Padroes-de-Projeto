using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Facade.Domain
{
    public class Payment
    {
        public string CreditCard { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public PaymentType PaymentType { get; set; }
        public string AccountNumber { get; set; }
        public string TransactionHash { get; set; }
    }

    public enum PaymentType
    {
        CreditCard = 1,
        DebitCard = 2,
        TranferBetweenAccounts = 3,

    }
}
