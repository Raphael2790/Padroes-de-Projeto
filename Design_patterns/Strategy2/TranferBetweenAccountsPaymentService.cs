using Design_patterns.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_patterns.Strategy2
{
    class TranferBetweenAccountsPaymentService : IPayment
    {
        private readonly ITranferBetweenAccountsPaymentFacade _paymentTranferBetweenAccountsFacade;
        public TranferBetweenAccountsPaymentService(ITranferBetweenAccountsPaymentFacade paymentTranferBetweenAccountsFacade)
        {
            _paymentTranferBetweenAccountsFacade = paymentTranferBetweenAccountsFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = (decimal)order.Products.Sum(o => o.Price);
            Console.WriteLine("Inciando tranferência bancária - Valor R$ " + payment.Total);

            payment.Status = "Pendente";

            payment.TransactionHash = _paymentTranferBetweenAccountsFacade.TransactionHash(payment.Total);
           
            payment.Status = payment.TransactionHash == string.Empty ? "Pagamento Não Aprovado" : "Pagamento Concluído";

            return payment;
        }
    }
}
