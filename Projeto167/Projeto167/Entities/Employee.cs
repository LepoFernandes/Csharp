using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto167.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }


        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nome: ").Append(Name).Append("\n");
            sb.Append("Salário: R$ ").Append(Payment().ToString("F2"));
            return sb.ToString();
        }
    }
}
