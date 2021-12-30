using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace WorkingWithFiles.Entity
{
    class Product
    {
        public string Name { get; set; }
        public double Valor { get; set; }
        public int Amount { get; set; }

        public Product(string name, double valor, int amount)
        {
            Name = name;
            Valor = valor;
            Amount = amount;
        }

        public double TotalValor()
        {
            return Valor * Amount;
        }

    }
}
