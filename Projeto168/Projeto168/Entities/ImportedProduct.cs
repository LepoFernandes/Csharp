using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto168.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(double customsFee, string name, double price)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder(base.PriceTag());
            sb.Append($"Customs fee: {CustomsFee:C} ");
            sb.Append($"Total Price: {TotalPrice():C} ");
            return sb.ToString();
        }
    }
}
