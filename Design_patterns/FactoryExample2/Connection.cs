using System;

namespace Design_patterns.FactoryExample2
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public bool Opened { get; set; }
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }

        public void Close()
        {
            Opened = false;
            Console.WriteLine("Conexão fechada");
        }

        public void ExecuteCommandScalar(string command)
        {
            Console.WriteLine("Executando comando : " + command);
        }
    }
}