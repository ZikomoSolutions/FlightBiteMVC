using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using FlightBite.Data;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;

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
        {
            return View();  
        }

       public async Task<IActionResult> AddEnquiry(EnquiryCreateViewModel viewModel)
        {
            try
            {
                var model = new EnquiryMasterModel()
                {
                    CompanyName = viewModel.CompanyName,
                    ContactPerson = viewModel.ContactPerson,
                    ATOL = viewModel.ATOL,
                    IATA = viewModel.IATA,
                    JobTitle = viewModel.JobTitle,
                    ContactEmail = viewModel.ContactEmail,
                    ContactPhone = viewModel.ContactPhone,
                    EnquiryPlatformId = 1,
                    EnquiryStatusId = 1,
                    UserTypeId = 1
                };
                var result = await _enquiryMaster.AddEnquiry(model);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }

            //return View();
        }

        public IActionResult OnClick()
        {
            return PartialView("_EnquiryPartial");
        }


    }
}