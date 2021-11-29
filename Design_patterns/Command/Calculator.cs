using System;

namespace Design_patterns.Command
{
    public class Calculator
    {
        private int _valorAtual;

        public void Operacao(char operationType, int value)
        {
            switch (operationType)
            {
                case '+': _valorAtual += value; break;
                case '-': _valorAtual -= value; break;
                case '*': _valorAtual *= value; break;
                case '/': _valorAtual /= value; break;
                default:
                    throw new NotImplementedException("Operação não reconhecida");
            }

            Console.WriteLine("(dado {1} {2}) - Valor Atual = {0,3}", _valorAtual, operationType, value);
        }
    }
}
