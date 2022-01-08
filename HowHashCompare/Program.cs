using System;
using System.Collections.Generic;
using HowHashCompare.Entities;

namespace HowHashCompare
{
    class Program

        //Se o tipo Product não sobrescreve os métodos equals e hashCode, então a comparação com o "Contais"
        //será por meio da referencia da variavel. Como sao dois objetos diferentes, então a comparação não será
        //Verdadeira. Caso o tipo Product sobrescreva os métodos equals e GetHashCode, então as definições nos métodos
        //que definão a comparação
    {
        static void Main(string[] args)
        {
            HashSet<Product> products = new HashSet<Product>();
            products.Add(new Product("Notebook", 1200.00));
            products.Add(new Product("Geladeira", 900.00));

            HashSet<Point> points = new HashSet<Point>();
            points.Add(new Point(10.0, 20.0));
            points.Add(new Point(2.0, 3.0));

            Product prod = new Product("Notebook", 1200.00); //True
            Console.WriteLine(products.Contains(prod));

            Point newPoint = new Point(10.0, 20.0); //True
            Console.WriteLine(points.Contains(newPoint));

        }
    }
}
