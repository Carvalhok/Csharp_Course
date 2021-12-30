using System;
using System.Collections.Generic;
using System.Text;
using WorkingWithInterfaces.Entity;

namespace WorkingWithInterfaces.Service
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void PrcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment =  Math.Ceiling(duration.TotalHours) * PricePerHour;
            }
            else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }

            double Tax = _brazilTaxService.Tax(basicPayment);
            carRental.InvoiceRental = new Invoice(basicPayment, Tax);
        }
    }
}
