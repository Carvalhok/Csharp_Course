using System;
using System.Collections.Generic;
using System.Text;

namespace Palavra_this.Entities
{
    //Uso da palavras this para aproveitamento de código em construtores
    class Exemplo
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Exemplo()
        {
            Quantidade = 0;
        }

        public Exemplo(string nome, double preco): this()
        {
            Preco = preco;
            Nome = nome;
        }

        public Exemplo(string nome, double preco, int quantidade):this(nome,preco)
        {
            Quantidade = quantidade;
        }
    }
}
