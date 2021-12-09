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

            // Passagem de um parâmetro tipo struct como referência para uma função void. 
            //Nesse caso, o próprio valor de x é alterado
            int x = 10;
            Calculator.Triple(ref x);
            Console.WriteLine(x);

            // Passagem de um parâmetro do tipo struct como referência para uma função que retorna uma variável de saída
            // Não é necessário iniciar a variável de saída

            int resultado;
            Calculator.Double(x, out resultado);

            Console.WriteLine(resultado);
        }
    }
}
