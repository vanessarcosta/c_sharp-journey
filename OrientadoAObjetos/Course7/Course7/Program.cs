﻿using System.Globalization;
using Course7.Entities;
using Course7.Services;

namespace Course7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarrRental carrRental = new CarrRental(start, finish, new Vehicle(model));

            RentalServices rentalServices = new RentalServices(hour, day, new BrazilTaxService());

            rentalServices.ProcessInvoice(carrRental);

            Console.WriteLine("INVOICE");
            Console.WriteLine(carrRental.Invoice);
        }
    }
}
