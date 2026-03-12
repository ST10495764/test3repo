using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

   
        public string? EventName { get; set; }

        public string? EventImg {  get; set; }

        public ICollection<Booking>? Bookings { get; set; }
    }
}
