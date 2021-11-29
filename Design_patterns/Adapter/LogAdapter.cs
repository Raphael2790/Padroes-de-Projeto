using System;

namespace Design_patterns.Adapter
{
    //Adapter class - implementa a mesma interface da classe base que será mudado o comportamento
    //porém recebe na implementação dos comportamentos devolve os comportamentos da classe de adaptação
    //tornando a mesma substituta onde for necessária via injeção de dependencia da classe base de logs
    public class LogAdapter : ILogger
    {
        private readonly ILogNetMaster _logNetMaster;
        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }
        public void Log(string message)
        {
            _logNetMaster.LogInfo(message);
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}
