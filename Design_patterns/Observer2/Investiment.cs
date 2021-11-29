using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Observer2
{
    public abstract class Investiment 
    {
        private decimal _value;
        private readonly List<IObservableExample> _observables = new List<IObservableExample>();

        protected Investiment(string simbol, decimal value)
        {
            _value = value;
            Simbol = simbol;
        }

        public string Simbol { get; }
        public decimal Value
        {
            get => this._value;
            set
            {
                if (value == _value) return;
                _value = value;

                Notify();
            }
        }

        private void Notify()
        {
            foreach (var investor in _observables)
                investor.Notify(this);

            Console.WriteLine("");
        }

        public void Subscribe(IObservableExample observer)
        {
            Console.WriteLine($"Notificando que {observer.Name} está se inscrevendo para receber atualizações de {Simbol}");
            _observables.Add(observer);
        }

        public void UnSubscribe(IObservableExample observer)
        {
            Console.WriteLine($"Notificando que {observer.Name} não quer mais receber atualizações de {Simbol}");
            _observables.Remove(observer);
        }
    }
}
