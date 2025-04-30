using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Projeto188.Entities
{
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string csvProduct)
        {
            string [] vect = csvProduct.Split(',');

            Name = vect[0];
            Price = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);

        }

        public int CompareTo(Product? obj)
        {
            if (!(obj is Product)) 
            {
                throw new ArgumentException("An error occurred: Argument is not a product.");
            }
                Product other = obj as Product;
                return Price.CompareTo(other.Price);
        }
    }
}
