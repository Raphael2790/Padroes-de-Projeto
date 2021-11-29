using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Observer2
{
    public static class ObserverExecution
    {
        public static void Execute() 
        {
            var joao = new ObserverExample("João");
            var pedro = new ObserverExample("Pedro");
            var carol = new ObserverExample("Carol");

            var amazon = new BovespaPaper("Amazon", NextDecimal());
            var microsoft = new BovespaPaper("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(pedro);

            microsoft.Subscribe(carol);
            microsoft.Subscribe(joao);

            Console.WriteLine("");
            Console.WriteLine("---------------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Value = NextDecimal();
                microsoft.Value = NextDecimal();

                if(i == 1)
                {
                    amazon.UnSubscribe(joao);
                }
            }
        }

        private static decimal NextDecimal()
        {
            return new Random().Next(141421, 314160)/(decimal)100000.00;
        }
    }
}
