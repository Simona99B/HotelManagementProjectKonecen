using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagementProjectKonecen.Models
{
    public class Booking
    {

        public Booking()
        {
            rooms = new List<Room>();
        }
        [Key]
        public int BookingId { get; set; }
     
       [Display(Name = "Customer Name")]
       [Required]
        public string CustomerName { get; set; }

        [Display(Name = "Customer Address")]
        [Required]
        public string CustomerAddress { get; set; }

        [Display(Name = "Customer Phone")]
        [Required]
        public string CustomerPhone { get; set; }

        [Display(Name = "Booking From")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Booking from is required.")]
        //[DisplayFormat(ApplyFormatInEditMode= true, DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? BookingFrom { get; set; }

        [Display(Name = "Booking To")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Booking to is required.")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MMM-yyyy}")]
        public DateTime? BookingTo { get; set; }

        //[Display(Name = "Assign Room")]
        //[Required(ErrorMessage = "Room is required.")]
        public int AssignRoomId { get; set; }

        [Display(Name = "Number Of Members")]
        [Required]
        [Range(1,4)]
        public int NumberOfMembers { get; set; }

        [Display(Name = "Total Price")]
        public int TotalAmount { get; set; }

        //public IEnumerable<SelectListItem> ListOfRooms { get; set; }

        public virtual ICollection<Room> rooms { get; set; }

    }
}
