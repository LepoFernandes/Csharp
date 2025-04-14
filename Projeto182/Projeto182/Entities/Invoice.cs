using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto182.Entities
{
    internal class Invoice
    {
        public double BasicPayments { get; set; }
        public double Tax { get; set; }

        public Invoice() { }

        public Invoice(double basicPayments, double tax)
        {
            BasicPayments = basicPayments;
            Tax = tax;
        }

        public double TotalPayment
        {
            get {  return BasicPayments + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayments.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: " 
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: " 
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
