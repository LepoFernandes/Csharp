using System;
using Projeto175.Entities.Exceptions;
using Projeto175.Entities;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            try
            {
                Console.WriteLine("Enter your account details ");

                Console.Write("Account number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Account holder: ");
                string holder = Console.ReadLine();

                Console.Write("Account balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: ");
                double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withdraw);
                Console.WriteLine("Account instantiated successfully");

                Console.WriteLine(account.ToString());

                Console.Write("How much do you want to withdraw: ");

                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(amount);
                Console.WriteLine("Withdraw sucessfully!");
                Console.WriteLine();
                Console.WriteLine(account.ToString());
            }
            catch (WithdrawException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error!" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}