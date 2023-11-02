using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? hotelName, int availableRooms, string? name, string? country, int rating) : base(name, country, rating)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }
        public string? HotelName { get; set; }
        public int AvailableRooms { get; set; }

        public async Task BookRoomsAsync(int roomsRequested)
        {
            Console.WriteLine($"Booking {roomsRequested} rooms at {HotelName}...");

            if (roomsRequested <= AvailableRooms)
            {
                await Task.Delay(2000);
                AvailableRooms -= roomsRequested;
                Console.WriteLine("Successfully booked " + roomsRequested + "rooms in " + HotelName);
            }
            else
            {
                Console.WriteLine("No rooms available for your selection");
            }
        }

    }
}
