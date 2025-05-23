﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto174.Entities.Exceptions;

namespace Projeto174.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)  
            {
                throw new DomainExceptions("Error! Check-out date must be after check-in date.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkOut <= checkIn)  
            {
                throw new DomainExceptions("Error! Check-out date must be after check-in date.");
            }
            if (checkOut < now || checkIn < now)
            {
                throw new DomainExceptions("Error! Reservation dates for update must be future dates.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
           
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
