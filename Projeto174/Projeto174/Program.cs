using System;
using Projeto174.Entities;
using Projeto174.Entities.Exceptions;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Welcome! Enter data to reservation:");
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

            }

            catch (DomainExceptions e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);

            }
        }
    }
}