﻿using Microsoft.VisualBasic;
using System;
using System.Globalization;
using Projeto182.Entities;
using Projeto182.Services;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");

            string model = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy HH:mm)");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm)");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);


            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));


            RentalService rentalService = new RentalService(hour, day,new BrasilTaxServices()); 

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

            
        }
    }
}