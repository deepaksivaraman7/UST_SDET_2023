using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        private static List<HotelRoom<T>> rooms = new();
        public static void BookReservation(int roomNumber, ref T roomType)
        {
            HotelRoom<T> hotelRoom = new(roomNumber, roomType, true);
            rooms.Add(hotelRoom);
            Console.WriteLine("Room number: {0}   Room type: {1}   Booked: {2}", hotelRoom.RoomNumber, hotelRoom.RoomType, hotelRoom.IsBooked);
        }
        public static void CancelReservation(int roomNumber)
        {
            foreach (var hotelRoom in rooms)
            {
                if (hotelRoom.RoomNumber == roomNumber)
                {
                    hotelRoom.IsBooked = false;
                }
                Console.WriteLine("Room number: {0}   Room type: {1}   Booked: {2}", hotelRoom.RoomNumber, hotelRoom.RoomType, hotelRoom.IsBooked);
            }
        }
    }
}
