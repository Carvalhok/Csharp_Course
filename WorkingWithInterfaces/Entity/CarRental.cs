using System;

namespace WorkingWithInterfaces.Entity
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle VehicleModel { get; set; }
        public Invoice InvoiceRental { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicleModel)
        {
            Start = start;
            Finish = finish;
            VehicleModel = vehicleModel;
            InvoiceRental = null;
        }
    }
}
