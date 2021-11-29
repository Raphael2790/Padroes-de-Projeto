namespace Design_patterns.Adapter
{
    public class AdapterExecution
    {
        public static void  Execute()
        {
            new TransactionService(new Logger()).MakeTransaction();
            new TransactionService(new LogAdapter(new LogNetMasterService())).MakeTransaction();
        }
    }
}
