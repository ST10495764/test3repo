using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }


        public int EventId { get; set; }

        public virtual Event? Event { get; set; }

        public int VenueId { get; set; }
        public virtual Venue? Venue { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
