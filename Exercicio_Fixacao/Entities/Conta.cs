using System;
using System.Globalization;

namespace Exercicio_Fixacao.Entities
{
    class Conta
    {
        public int Numero { get; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }


        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
            Saldo = 0;
        }
        public Conta (int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Saldo = depositoInicial;
        }

        public void AlteraNomeTitular(string nome)
        {
            Nome = nome;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Retirada(double valor)
        {
            Saldo = Saldo - valor - 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
