using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? location, int rating, double pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int Rating { get; set; }
        public double PricePerNight { get; set; }
        public static List<TouristDestination> Destinations = new()
        {
            new TouristDestination("Agra","India",5,300),
            new TouristDestination("Pyramid","Egypt",3,400),
            new TouristDestination("Berlin","Germany",5,700),
            new TouristDestination("Jerusalem","Israel",1,200),
            new TouristDestination("Trivandrum","India",5,700),
            new TouristDestination("Kochi","India",5,200)

        };

        public static void ViewDestinationsByRating(int rating)
        {
            var result = Destinations.Where(d => d.Rating >= rating).OrderByDescending(d=>d.Rating);
            foreach(var destination in result) 
            {
                Console.WriteLine("Name: {0}   Location: {1}   Rating: {2}   Price per night: {3}", destination.Name, destination.Location, destination.Rating, destination.PricePerNight);
            }
        }
        public static void SortByPrice()
        {
            var result = Destinations.OrderBy(d => d.PricePerNight);
            foreach (var destination in result)
            {
                Console.WriteLine("Name: {0}   Location: {1}   Rating: {2}   Price per night: {3}", destination.Name, destination.Location, destination.Rating, destination.PricePerNight);
            }
        }
        public static void Filter(string location)
        {
            var result = Destinations.Where(d => d.Location==location);
            foreach (var destination in result)
            {
                Console.WriteLine("Name: {0}   Location: {1}   Rating: {2}   Price per night: {3}", destination.Name, destination.Location, destination.Rating, destination.PricePerNight);
            }
        }
    }
}
