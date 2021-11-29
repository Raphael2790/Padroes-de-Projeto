using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Adapter
{
    //Adptee class - classe com novo comportamento implementado
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogException(Exception exception)
        {
            Console.WriteLine("Log customizado - " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("Log customizado - " + message);
        }
    }
}
