using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        public LoadBalancer()
        {
            _servers = new List<Server>
            {
               new Server {Id = Guid.NewGuid(), Name = "ServerI", IP="190.12.343.18"},
               new Server {Id = Guid.NewGuid(), Name = "ServerII", IP = "120.23.234.21"},
               new Server {Id = Guid.NewGuid(), Name = "ServerIII", IP = "123.24.235.12"}
            };
        }
        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
