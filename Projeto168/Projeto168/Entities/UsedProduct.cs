using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto168.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(DateTime manufactureDate, string name, double price)
            : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder(base.PriceTag()); 
            sb.Append($"(used) "); 
            sb.Append($"Manufacture date: {ManufactureDate:dd/MM/yyyy} ");
            return sb.ToString();
        }
    }
}
