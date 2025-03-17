using Projeto167.Entities;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>(); 

            Console.Write("Quantos funcionários deseja cadastrar? ");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                string resposta = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resposta == "y")
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Employee terceirizado = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(terceirizado);
                } else
                {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());  
            }
        }
    }
}
