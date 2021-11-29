namespace Design_patterns.Facade.Domain
{
    public interface IPayment
    {
        Payment MakePayment(Order order, Payment payment);
    }
}
