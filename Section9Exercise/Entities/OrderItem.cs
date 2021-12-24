using System;
using System.Collections.Generic;
using System.Text;

namespace Section9Exercise.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Products { get; set; }

        public OrderItem()
        {
        }
        public OrderItem(int quantity, Product products)
        {
            Quantity = quantity;
            Products = products;
        }

        public double SubTotal()
        {
            return Quantity * Products.Price;
        }


    }
}
