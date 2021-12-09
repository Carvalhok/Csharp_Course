using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            //Add adiciona ao final da lista
            lista.Add("Keverson");
            lista.Add("Leial");
            lista.Add("Paulo");

            // Insert insere na posição desejada
            lista.Insert(1, "Marco");
            lista.Insert(2, "Adriano");
            lista.Insert(3, "Kerlley");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }

            // Mostra o tamanho da lista
            Console.WriteLine("Mostra o tamanho da lista: " + lista.Count);

            //Função Find o primeiro elementod da lista de acordo com um parâmetros definido por uma expressão lambda
            string s1 = lista.Find(x => x[0] == 'K');
            Console.WriteLine(s1);

            //Igual a função Find, porém agora a função Findlast acha o último elemento de acordo com a expressão lambda 
            string s2 = lista.FindLast(x => x[0] == 'K');
            Console.WriteLine(s2);

            // Mesma coisa das funões Find e FindLast, porém agora pega-se a posição do elemento
            int pos1 = lista.FindIndex(x => x[0] == 'K');
            int pos2 = lista.FindLastIndex(x => x[0] == 'K');
            Console.WriteLine(pos1);
            Console.WriteLine(pos2);
        }
    }
}
