using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.FactoryExample2
{
    public class SqlDbConnector : DbConnector
    {
        public SqlDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco SqlServer");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
