using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto182.Services
{
    internal class BrasilTaxServices : ITaxService
    {
        public double Tax (double Amount)
        {
            if (Amount <= 100)
            {
                return Amount * 0.2;
            }
            else
            {
                return Amount * 0.15;
            }
        }
    }
}
