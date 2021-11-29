using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_patterns.Facade.Domain
{
    //classe de dominio que não deve mudar por implementações externas
    public class CreditCardPaymentService : IPayment
    {
        private ICreditCardPaymentFacade _creditcardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditcardPaymentFacade)
        {
            _creditcardPaymentFacade = creditcardPaymentFacade;
        }

        public Payment MakePayment(Order order, Payment payment)
        {
            payment.Total = (decimal)order.Products.Sum(x => x.Price);
            Console.WriteLine("Iniciando pagamento via cartão de crédito - Valor $ " + payment.Total);

            if(_creditcardPaymentFacade.MakePayment(order, payment))
            {
                payment.Status = "Pago via cartão de crédito";
                return payment;
            }

            payment.Status = "Cartão recusado!";
            return payment;
        }
    }
}
