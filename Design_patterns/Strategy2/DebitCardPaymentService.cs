using Design_patterns.Facade.Domain;
using System;
using System.Linq;

namespace Design_patterns.Strategy2
{
    public class DebitCardPaymentService : IPayment
    {
        private readonly IDebitCardPaymentFacade _debitCardPaymentFacade;
        public DebitCardPaymentService(IDebitCardPaymentFacade debitCardPaymentFacade)
        {
            _debitCardPaymentFacade = debitCardPaymentFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = (decimal)order.Products.Sum(x => x.Price);
            Console.WriteLine("Iniciando pagamento via cartão de débito - Valor $ " + payment.Total);

            if (_debitCardPaymentFacade.MakePayment(order, payment))
            {
                payment.Status = "Pago via cartão de débito";
                return payment;
            }

            payment.Status = "Cartão recusado!";
            return payment;
        }
    }
}
