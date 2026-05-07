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

            public async Task<IActionResult> BookingHistory()
            {
                var bookingHistory = await _context.Booking
                    .Include(b => b.Event)
                    .Include(b => b.Venue)
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


