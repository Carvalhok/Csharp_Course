using System;
using System.Globalization;

namespace membrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(3.0);
            double volume = Calculadora.Volume(3.0);
            double pi = Calculadora.pi;
        }
    }
}
