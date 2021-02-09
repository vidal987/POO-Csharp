using ExecLocadora0.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExecLocadora0.Services
{
    class RentalService
    {
        public double PricePerHour  { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basciPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basciPayment = PricePerHour * Math.Ceiling(duration.TotalHours);

            }
            else
            {
                basciPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basciPayment);

            carRental.Invoice = new Invoice(basciPayment, tax);
        }
    }
}
