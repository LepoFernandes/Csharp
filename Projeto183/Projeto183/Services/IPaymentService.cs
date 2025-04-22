using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto183.Services
{
    public interface IPaymentService
    {
        double interest(double amount, int months);
        double paymentFee(double amount);
    }
}
