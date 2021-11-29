using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Command
{
    public class CalculatorCommand : Commander
    {
        private int _value;
        private char _operator;
        private Calculator _calculator;

        public CalculatorCommand(int value, char operationType, Calculator calculator)
        {
            _calculator = calculator;
            _operator = operationType;
            _value = value;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public int Operand
        {
            set => _value = value;
        }

        public override void Execute()
        {
            _calculator.Operacao(_operator, _value);
        }

        public override void Undo()
        {
            _calculator.Operacao(Undo(_operator), _value);
        }

        private char Undo(char @operator)
        {
            return @operator switch
            {
                '+' => '-',
                '-' => '+',
                '*' => '/',
                '/' => '*',
                _ => throw new NotImplementedException("Operador não reconhecido"),
            };
        }
    }
}
