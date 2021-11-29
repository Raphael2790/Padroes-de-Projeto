namespace Design_patterns.FactoryExample2
{
    public class SqlFactory : DbFactory
    {
        //Implementação do factory method 
        public override DbConnector CreateConnector(string connectionString)
        {
            return new SqlDbConnector(connectionString);
        }
    }
}
