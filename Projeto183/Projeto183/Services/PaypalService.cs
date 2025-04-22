using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto183.Services
{
    public class PaypalService : IPaymentService
    {
        public double interest(double amount, int month)
        {
            return amount * 0.01 * month;   
        }

        public double paymentFee (double amount)
        {
            return amount * 0.02;
        }
    }
    
    
}
