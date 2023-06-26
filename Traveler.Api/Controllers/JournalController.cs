using Microsoft.AspNetCore.Mvc;

namespace Traveler.Api.Controllers
{
    public class JournalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
