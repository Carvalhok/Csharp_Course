using System;
using Exceções.Entities.Exceptions;

namespace Exceções.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if(checkout <= checkin)
            {
                throw new DomainException("Check-out must be aftere check-in date");
            }

            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public double Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out must be aftere check-in date");
            }

            else if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }

            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", Check-out: "
                + Checkout.ToString("dd/MM/yyy")
                + ", "
                + Duration()
                + " nights ";
        }

    }
}
