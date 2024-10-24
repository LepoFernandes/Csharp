using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto144
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary) 
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AumentarSalario(double percentual)
        {
            
            Salary += Salary * percentual / 100;
        }

        public override string ToString() 
        {
            return 
                "Funcionario: " + Name
                + " ID: " + Id
                + " Salario: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
