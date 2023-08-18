using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IEnquiryMaster _enquiryMaster;

        public HomeController(IEnquiryMaster enquiryMaster)
        {
            this._enquiryMaster = enquiryMaster;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _enquiryMaster.GetAllEnquiry();
                return View(result);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }


        public IActionResult Client()

        public IActionResult AddEnquiry()
        {
            return View();
        }
    }
}
