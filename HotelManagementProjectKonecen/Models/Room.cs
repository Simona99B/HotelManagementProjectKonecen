using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementProjectKonecen.Models
{
    public class Room
    {
        public Room()
        {
            bookings = new List<Booking>();
        }
        public int RoomId { get; set; }

        [Display(Name = "Room No.")]
        [Required]
        public int RoomNumber { get; set; }

        [Display(Name = "Room Image")]
        public string RoomImage { get; set; }

        [Display(Name = "Room Price")]
        [Range(500, 10000)]
        [Required]
        public decimal RoomPrice { get; set; }

        [Display(Name = "Booking Status")]
        //[Required(ErrorMessage = "Booking status is required.")]
        public string BookingStatusId { get; set; }

        //[Display(Name = "Room Type")]
        //[Required(ErrorMessage = "Room type is required.")]
        public string RoomTypeId { get; set; }

        [Required]
        [Display(Name = "Room Capacity")]
        [Range(1, 8)]
        public int RoomCapacity { get; set; }
        //public HttpPostedFileBase Image { get; set; }

        [Required]
        [Display(Name = "Room Description")]
        public string RoomDescription { get; set; }

        //public List<SelectListItem> ListOfBookingStatus { get; set; }
        //public List<SelectListItem> ListOfRoomType { get; set; }

        public virtual ICollection<Booking> bookings { get; set; }

        [Display(Name = "Booked From")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Booking from is required.")]
        //[DisplayFormat(ApplyFormatInEditMode= true, DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? BookedFrom { get; set; }

        [Display(Name = "Booked To")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Booking to is required.")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? BookedTo { get; set; }

        /* public enum StatusId
         {
             Free,
             Reserved


         }*/

        //public StatusId BookingStatusId { get; set; }









    }
}
