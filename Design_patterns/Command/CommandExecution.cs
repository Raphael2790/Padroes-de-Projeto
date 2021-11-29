using System;

namespace Design_patterns.Command
{
    public class CommandExecution
    {
        public static void Execute()
        {
            var user = new User();

            user.Add('+', 100);
            Console.ReadKey();
            user.Add('-', 50);
            Console.ReadKey();
            user.Add('*', 10);
            Console.ReadKey();
            user.Add('/', 2);

            user.Undo(4);
            Console.ReadKey();

            user.DoAgain(3);
        }
    }
}
