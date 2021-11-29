using Design_patterns.Facade.CrossCutting;
using Design_patterns.Facade.Domain;
using System;

namespace Design_patterns.Strategy2
{
    public class PaymentFactory
    {
        public static IPayment CreatePayment(PaymentType paymentType)
        {
            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    return new CreditCardPaymentService(new CreditcardPaymentFacade(new PayPalGateway(),new ConfigurationManager()));
                case PaymentType.DebitCard:
                    return new DebitCardPaymentService(new DebitCardPaymentFacade(new PayPalGateway(), new ConfigurationManager()));
                case PaymentType.TranferBetweenAccounts:
                    return new TranferBetweenAccountsPaymentService(new TranferBetweenAccountsPaymentFacade());
                default:
                    throw new NotImplementedException("Meio de pagamento não reconhecido");
            }
        }
    }
}
