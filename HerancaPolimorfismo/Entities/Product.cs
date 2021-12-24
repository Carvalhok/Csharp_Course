using System.Globalization;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append(Name + " $ ");
            priceTag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));

            return priceTag.ToString();
        }
    }


}
