using System;
using HotelReservation.Entities.Exceptions;

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
            if (checkout <= checkin)
            {
                throw new DomainException("Checkout date must be after checkin date");
            }

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
            DateTime now = DateTime.Now;
            if(checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");//encerra o método
            }
            if(checkout <= checkin)
            {
                throw new DomainException("Checkout date must be after checkin date");
            }

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
