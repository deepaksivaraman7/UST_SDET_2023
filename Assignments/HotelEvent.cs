using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelEvent
    {
        public HotelEvent(string? eventName, DateOnly eventDate, string? location, int capacity)
        {
            EventName = eventName;
            EventDate = eventDate;
            Location = location;
            Capacity = capacity;
        }

        public string? EventName { get; set; }
        public DateOnly EventDate { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }
        public static List<HotelEvent> Events = new();
        public static void Add(HotelEvent hotelEvent)
        {
            Events.Add(hotelEvent);
            Console.WriteLine("Event added");
        }
        public static void SendNotification()
        {
            foreach(HotelEvent hotelEvent in Events)
            {
                if (hotelEvent.EventDate.ToString() == DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("You have one event today\nEvent name: {0}\nLocation: {1}\nCapacity: {2}", hotelEvent.EventName, hotelEvent.Location, hotelEvent.Capacity);
                }
            }
        }
        public static void SendStatus()
        {
            foreach (HotelEvent hotelEvent in Events)
            {
                if (hotelEvent.EventDate.ToString() != DateTime.Today.ToShortDateString())
                {
                    Console.WriteLine("Other events\nEvent name: {0}\nLocation: {1}\nCapacity: {2}\nDate: {3}", hotelEvent.EventName, hotelEvent.Location, hotelEvent.Capacity,hotelEvent.EventDate);
                }
            }
        }
    }
}
