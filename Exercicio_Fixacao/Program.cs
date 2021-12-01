using System;
using System.Globalization;
using Exercicio_Fixacao.Entities;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá o valor de depósito inicial(s/n): ");
            char resp = char.Parse(Console.ReadLine());
            Conta conta;

            if (resp == 's')
            {
                Console.Write("Entre com o valor do Depósito Inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numero, nome, valorInicial);
            }
            else { 
                conta = new Conta(numero, nome);
            }

            Console.WriteLine(conta);

            Console.Write("Entre com o valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine(conta);

            Console.Write("Entre com o valor para retirada: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Retirada(valor);
            Console.WriteLine(conta);

            Console.WriteLine("Entre com o nome do novo titular da conta: ");
            string nomeNovo = Console.ReadLine();
            conta.AlteraNomeTitular(nomeNovo);
            Console.WriteLine(conta);
        }
    }
}
