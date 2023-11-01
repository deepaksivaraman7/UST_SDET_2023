using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }
        public static List<TourismDestination> Destinations = new()
        {
            new TourismDestination("Agra","India",5),
            new TourismDestination("Pyramid","Egypt",3),
            new TourismDestination("Berlin","Germany",1),
            new TourismDestination("Jerusalem","Israel",4)
        };
        public static void AddDestination(TourismDestination destination)
        {
            Destinations.Add(destination);
            var result = Destinations.OrderByDescending(d => d.Rating);
            foreach (var d in result)
            {
                Console.WriteLine("Name: {0}   Country: {1}   Rating: {2}", d.Name, d.Country, d.Rating);
            }
        }
    }

}
