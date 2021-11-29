using System;
using System.Collections.Generic;

namespace Design_patterns.Command
{
    public class User
    {
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Commander> _commands = new List<Commander>();
        private int _total;

        public void Add(char operationType, int value)
        {
            Commander command = new CalculatorCommand(value, operationType, _calculator);
            command.Execute();

            _commands.Add(command);
            _total++;
        }

        public void Undo(int nivels)
        {
            Console.WriteLine("\n ----- Desfazendo {0} níveis", nivels);
            for (int i = 0; i < nivels; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Undo();
            }
        }

        public void DoAgain(int nivels)
        {
            Console.WriteLine("\n ----- Retornando {0} níveis", nivels);
            for (int i = 0; i < nivels; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[++_total];
                command.Execute();
            }
        }
    }
}