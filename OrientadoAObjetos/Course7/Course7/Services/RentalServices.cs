using Course7.Entities;

namespace Course7.Services
{
    class RentalServices
    {
        public  double PricePerHour { get; private set; }

        public double  PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalServices(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarrRental carrRental)
        {
            TimeSpan duration = carrRental.Finish.Subtract(carrRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carrRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
