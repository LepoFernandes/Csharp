using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto168.Entities
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
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name} ");
            sb.Append($"Price: {Price:C} "); 
            return sb.ToString();
        }
    }
}
