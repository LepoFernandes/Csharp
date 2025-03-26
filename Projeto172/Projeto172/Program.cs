using System;
using Projeto172.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter data to reservation:");
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Check-in date: (dd/MM/YYYY)");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Check-out date: (dd/MM/YYYY)");
            DateTime checkout = DateTime.Parse(Console.ReadLine());


            if (checkout <= checkin)
            {
                Console.WriteLine("Error! Check-out date must to be after check-in date");
            }
            else 
            {
                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation: ");

                Console.WriteLine("Check-in date: (dd/MM/YYYY)");
                checkin = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Check-out date: (dd/MM/YYYY)");
                checkout = DateTime.Parse(Console.ReadLine());


                DateTime now = DateTime.Now;

                if ( checkout < now  ||  checkin < now )
                {
                    Console.WriteLine("Error! Reservation date for update must be future dates.");
                }
                else if(checkout <= checkin)
                {
                    Console.WriteLine("Error! Check-out date must to be after check-in date");
                } else
                {
                    reservation.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + reservation);
                }

            }                
        }
    }
}