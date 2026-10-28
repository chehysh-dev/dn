using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Action secured with [Authorize] attribute
        // Redirects unauthenticated users to the Login page automatically
        [Authorize]
        public IActionResult Secret()
        {
            return View();
        }
    }
}
