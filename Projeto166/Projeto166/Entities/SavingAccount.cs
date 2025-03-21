﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto166.Entities
{
   class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount()
        {
        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }


        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

         public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
