using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagementProjectKonecen.Models
{
    public class RoomBooking
    {
        public Room room { get; set; }
        public List<Booking> Bookings { get; set; }
        public int RoomId { get; set; }

        public int BookingId { get; set; }

        public int BookingFrom { get; set; }
        public int BookingTo { get; set; }
        public int AssignRoom { get; set; }
        


    }
}