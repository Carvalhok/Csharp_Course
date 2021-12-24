using System;
using System.Collections.Generic;
using System.Text;
using Section9Exercise.Entities.Enum;
using System.Globalization;

namespace Section9Exercise.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Clients { get; set; }
        public List<OrderItem> ListOfOrder { get; set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Clients = client;
        }

        public void AddItem(OrderItem item)
        {
            ListOfOrder.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            ListOfOrder.Remove(item);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem item in ListOfOrder)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());

            sb.Append("Cliente: ");
            sb.Append(Clients.Name);
            sb.Append(" (" + Clients.BirthDate.ToString("dd/MM/yyyy") + ") ");
            sb.AppendLine(" - " + Clients.Email);

            sb.AppendLine("Order items: ");
            foreach(OrderItem item in ListOfOrder)
            {
                sb.Append(item.Products.Name + ", $");
                sb.Append(item.Products.Price.ToString("F2", CultureInfo.InvariantCulture) + ", ");
                sb.Append("Quantity: " + item.Quantity + ", ");
                sb.AppendLine("Subtotal: $" + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            sb.Append("Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
          
            return sb.ToString();
            
        }

    }
}
