using Projeto183.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto183.Services
{
    public class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.interest(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.paymentFee(updatedQuota);

                contract.Installments.Add(new Installment(dueDate, fullQuota));
            }
        }
    }
}
