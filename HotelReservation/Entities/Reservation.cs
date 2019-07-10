using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", Check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
