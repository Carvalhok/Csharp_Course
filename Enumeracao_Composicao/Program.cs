using System;
using Enumeracao_Composicao.Entities;
using Enumeracao_Composicao.Entities.Enums;

namespace Enumeracao_Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            order order = new order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = orderStatus.PendingPeyment
            };

            Console.WriteLine(order);

            string txt = orderStatus.Delivered.ToString();

            orderStatus os = Enum.Parse<orderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
