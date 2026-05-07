using EventEase.Models;

namespace EventEase.ViewModels
{
    public class BookingHistoryViewModel
    {
        public List<Booking>? Bookings {  get; set; }

        public int? BookingId {  get; set; }

        public string? EventName { get; set; }

        public string? VenueName { get; set; }

        public int? VenueCapacity { get; set; }

        public string? VenueLocation { get; set; }

        public string? VenueImg { get; set; }

        public DateTime? StartDate {  get; set; }

        public DateTime? EndDate { get; set; }
    }
}