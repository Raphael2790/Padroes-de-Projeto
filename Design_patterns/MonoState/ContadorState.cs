using System.Globalization;
namespace Design_patterns.MonoState
{
    //Todas instâncias de contador state compartilham os mesmos atributos privados estáticos
    //Porém possuem referencia de memoria diferentes, oportunidade para compartilhar informações em classes derivadas
    public class ContadorState
    {
        private static int _contador;

        public int Contador 
        {
            get => _contador;
            set => _contador = value;
        }
    }
}