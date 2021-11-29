using System;
using Exceções.Entities;
using Exceções.Entities.Exceptions;

namespace Exceções
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime chekcInDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime chekcOutDate = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, chekcInDate, chekcOutDate);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                chekcInDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                chekcOutDate = DateTime.Parse(Console.ReadLine());
              
                reservation.UpdateDates(chekcInDate, chekcOutDate);
                Console.WriteLine("Reservation: " + reservation);

            }

            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}
