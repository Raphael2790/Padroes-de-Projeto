namespace Design_patterns.Strategy2
{
    public interface ITranferBetweenAccountsPaymentFacade 
    {
        string TransactionHash(decimal transactionValue);
    }
}
