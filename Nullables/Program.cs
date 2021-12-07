using System;
using Nullables;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Operador de coalscência nulo

            double a = x ?? 5;
            double b = y ?? 0.0;

            Console.WriteLine(a);
            Console.WriteLine(b);



        }
    }
}
