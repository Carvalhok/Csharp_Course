using System;
using Propriedades.Entities;

namespace Propriedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("TV", 800.00, 3);
            produto.Nome = "Mouse";
            Console.WriteLine(produto);
            
        }
    }
}
