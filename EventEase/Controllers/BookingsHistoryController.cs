using EventEase.Data;
using Microsoft.AspNetCore.Mvc;
using EventEase.ViewModels;
using Microsoft.EntityFrameworkCore;


namespace EventEase.Controllers
    {
        public class BookingsHistoryController : Controller
        {
            private readonly EventEaseContext _context;

            public BookingsHistoryController(EventEaseContext context)
            {
                _context = context;
            }

        public async Task<IActionResult> BookingHistory(int? bookingId,string eventName,DateTime? startDate,DateTime? endDate)
        {
            var query = _context.Booking
                .Include(b => b.Event)
                .Include(b => b.Venue)
                .AsQueryable();

            // Filter by Booking ID
            if (bookingId.HasValue)
            {
                query = query.Where(b =>
                    b.BookingId == bookingId.Value);
            }

            // Filter by Venue Name
            if (!string.IsNullOrEmpty(eventName))
            {
                query = query.Where(b =>
                    b.Event!.EventName!.Contains(eventName));
            }

            // Filter by Start Date
            if (startDate.HasValue)
            {
                query = query.Where(b =>
                    b.StartDate.Date >= startDate.Value.Date);
            }

            // Filter by End Date
            if (endDate.HasValue)
            {
                query = query.Where(b =>
                    b.EndDate.Date <= endDate.Value.Date);
            }

            // IMPORTANT: USE query NOT _context.Booking
            var bookingHistory = await query
                .Select(b => new BookingHistoryViewModel
                {
                    BookingId = b.BookingId,

                    EventName = b.Event!.EventName,

                    VenueName = b.Venue!.VenueName,

                    VenueCapacity = b.Venue.VenueCapaity,

                    VenueLocation = b.Venue.VenueLocation,

                    VenueImg = b.Venue.VenueImg,

                    StartDate = b.StartDate,

                    EndDate = b.EndDate,
                })
                .ToListAsync();

            return View(bookingHistory);
        }
    }
    }


