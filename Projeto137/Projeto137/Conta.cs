using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto137
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public Conta() { }
        public Conta (int numeroConta)
        {
            NumeroConta = numeroConta;
        }

        public Conta(int numeroConta, string nomeTitular, double saldo) : this(numeroConta)
        {
            NomeTitular = nomeTitular;
            Saldo = saldo;
        }

        public double deposito( double valorDeposito)
        {
            return Saldo += valorDeposito;
        }
        public double saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque - 5.0;
            return Saldo;
        }
        public override string ToString()
        {
            return
                "Nome: " +
                NomeTitular +
                ", Conta: " +
                NumeroConta +
                ", Saldo: " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
