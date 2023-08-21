using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ClientInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
