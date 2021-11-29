using System;

namespace Design_patterns.Observer2
{
    public class ObserverExample : IObservableExample
    {
        public string Name { get; }
        public ObserverExample(string name)
        {
            Name = name;
        }

        public void Notify(Investiment investiment)
        {
            Console.WriteLine("Notificando {0} que {1} teve preço alterado para {2:C}", Name, investiment.Simbol, investiment.Value);
        }
    }
}
