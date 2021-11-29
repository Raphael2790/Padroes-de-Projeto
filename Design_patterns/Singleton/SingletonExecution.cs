using System;

namespace Design_patterns.Singleton
{
    public class SingletonExecution
    {
        public static void Execute()
        {
            var loadBalancer = LoadBalancer.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                var serverName = loadBalancer.NextServer.Name;
                Console.WriteLine("Disparando request para o servidor : " + serverName);
            }
        }
    }
}
