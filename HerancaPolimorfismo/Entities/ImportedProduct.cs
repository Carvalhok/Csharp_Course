using System.Globalization;
using System.Text;

namespace HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append(Name + " $ ");
            TotalPrice();
            priceTag.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            priceTag.Append($" (Customs Fee: $ {CustomsFee})");

            return priceTag.ToString();
        }

        public double TotalPrice()
        {
            return Price += CustomsFee;
        }
    }
}
