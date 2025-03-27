using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto175.Entities.Exceptions;

namespace Projeto175.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawlimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdrawlimit;
        }


        public void Deposit(double amount) 
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance < amount) 
            {
                throw new WithdrawException("Error! The balance is insufficient");
            }
            if (amount > WithDrawLimit) 
            {
                throw new WithdrawException("Error! Insufficient withdraw limit");
            }
            
            Balance -= amount;
        }

        public override string ToString()
        {
            return "Number: " + Number +
                   ", Holder: " + Holder +
                   ", Balance: " + Balance.ToString("F2") +
                   ", WithDraw Limit: " + WithDrawLimit.ToString("F2");
        }
    }
}
