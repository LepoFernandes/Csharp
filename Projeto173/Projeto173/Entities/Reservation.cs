using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto173.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        // Alterado para retornar uma string indicando sucesso ou erro
        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkOut <= checkIn)  // Aqui os parâmetros estão corretos
            {
                return "Error! Check-out date must be after check-in date.";
            }
            if (checkOut < now || checkIn < now)
            {
                return "Error! Reservation dates for update must be future dates.";
            }

            // Atualiza os atributos da classe
            CheckIn = checkIn;
            CheckOut = checkOut;
            return "Reservation updated successfully!";
        }

        public override string ToString()
        {
            return "Room " + RoomNumber +
                   ", check-in: " + CheckIn.ToString("dd/MM/yyyy") +
                   ", check-out: " + CheckOut.ToString("dd/MM/yyyy") +
                   ", " + Duration() + " nights.";
        }
    }
}
