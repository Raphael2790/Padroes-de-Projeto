namespace Design_patterns.Facade.Domain
{
    public interface ICreditCardPaymentFacade
    {
        bool MakePayment(Order order, Payment payment);
    }
}
