using System;
using System.Globalization;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }
        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append(Name + " (Used) $ ");
            priceTag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            priceTag.Append(" (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")");

            return priceTag.ToString();
        }

    }
}
