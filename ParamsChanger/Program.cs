using System;

namespace ParamsChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definição de função com parâmetros variados
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 6);
            int s3 = Calculator.Sum(2, 4, 3, 7);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            int x = 10;
            Calculator.Triple(ref x);
            Console.WriteLine(x);
        }
    }
}
