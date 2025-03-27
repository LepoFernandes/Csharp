using System;
using Projeto173.Entities;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter data to reservation:");
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error! Check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine("\nEnter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());

                string result = reservation.UpdateDates(checkin, checkout);
                Console.WriteLine(result);

                if (result == "Reservation updated successfully!")
                {
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}