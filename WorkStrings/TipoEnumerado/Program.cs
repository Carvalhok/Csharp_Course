using System;
using TipoEnumerado.Entities;
using TipoEnumerado.Entities.Enum;

namespace TipoEnumerado
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1800,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPeyment
            };

        Console.WriteLine(order);

            // Convertendo tipo enumerado para string
            String str = OrderStatus.PendingPeyment.ToString();

            //Convertendo string para tipo enumerado
            OrderStatus os = Enum.Parse<OrderStatus>("PendingPeyment");

            Console.WriteLine(str);
            Console.WriteLine(os);

        }
    }
}
