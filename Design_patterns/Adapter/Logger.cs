using System;

namespace Design_patterns.Adapter
{
    //Target class - classe que queremos mudar o comportamento na chamada do serviço
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log padrão - " + message);
        }

        public void LogError(Exception exception)
        {
            Console.WriteLine("Log padrão - " + exception.Message);
        }
    }
}
