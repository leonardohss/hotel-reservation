using System;
using HotelReservation.Entities;

namespace HotelReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in Date (dd/mm/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out Date (dd/mm/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
        }
    }
}
