using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Venue
    {
        [Key]
        public int VenueId { get; set; }

        public string VenueName { get; set; }

        public string VenueLocation { get; set; }

        public int VenueCapaity { get; set; }

        public string VenueImg { get; set; }

        public ICollection<Booking>? Bookings { get; set; } 
    }
}
