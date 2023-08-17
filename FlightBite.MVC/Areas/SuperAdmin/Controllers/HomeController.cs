using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IEnquiryMaster _enquiryMasterRepository;

        public HomeController(IEnquiryMaster enquiryMaster)
        {
            this._enquiryMasterRepository = enquiryMaster;
        }
        public async Task<IActionResult> Index()
        {
            try
            {
                var result = await _enquiryMasterRepository.GetAllEnquiry();
                return View(result);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public IActionResult AddEnquiry()
        {
            return View();
        }
    }
}
