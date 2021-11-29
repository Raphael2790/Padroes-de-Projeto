using Design_patterns.Facade.Domain;

namespace Design_patterns.Strategy2
{
    public interface IDebitCardPaymentFacade
    {
        bool MakePayment(Order order, Payment payment);
    }
}
