using EventEase.Models;

namespace EventEase.Controllers
{
    public class BookingHistoryViewModel
    {
        public List<Booking>? Bookings {  get; set; }

        public string? BookingNameSearch {  get; set; }

        public string? EventNameSearch { get; set; }

        public string? VenueNameSearch { get; set; }

        public DateTime? StartDateSearch {  get; set; }

        public DateTime? EndDateSearch { get; set; }
    }
}