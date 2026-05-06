using Microsoft.AspNetCore.Mvc;

namespace EventEase.Controllers
{
    public class BlobsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
