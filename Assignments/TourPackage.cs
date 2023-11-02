using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public TourPackage(int packageId, string? destination, DateOnly startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public DateOnly StartDate { get; set; }
        public double Price { get; set; }

        private static List<TourPackage> TourPackages = new List<TourPackage>();


        public static void AddTourPackage(TourPackage tourPackage)
        {
            TourPackages.Add(tourPackage);
        }
        public static void BookPackage(int packageID)
        {
            Console.WriteLine($"Booking package {packageID}...");

            // Ensure that the package ID is valid
            TourPackage? selectedPackage = TourPackages.Find(p => p.PackageId == packageID);

            if (selectedPackage != null)
            {
                // Simulate booking process
                Thread.Sleep(2000);

                lock (selectedPackage)
                {
                    // Display booking confirmation
                    Console.WriteLine($"Booking confirmation for package {packageID}:");
                    Console.WriteLine($"Destination: {selectedPackage.Destination}");
                    Console.WriteLine($"Start Date: {selectedPackage.StartDate}");
                    Console.WriteLine($"Total Price: {selectedPackage.Price}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Invalid package ID: {packageID}. Booking failed.");
            }
        }
    }
}
