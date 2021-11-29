namespace Design_patterns.Adapter
{
    public class TransactionService 
    {
        private readonly ILogger _logger;
        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void MakeTransaction()
        {
            _logger.Log("Transação realizada");
        }
    }
}
