using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using FlightBite.Data;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;
using Microsoft.AspNetCore.Components.Forms;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IEnquiryMaster _enquiryMaster;
        private readonly IUserType _userType;
        private readonly IEnquiryPlatform _enquiryPlatform;
        private readonly IEnquiryStatus _enquiryStatus;

        public HomeController(IEnquiryMaster enquiryMaster, IUserType userType, IEnquiryPlatform enquiryPlatform, IEnquiryStatus enquiryStatus)
        {
            this._enquiryMaster = enquiryMaster;
            this._userType = userType;
            this._enquiryPlatform = enquiryPlatform;
            this._enquiryStatus = enquiryStatus;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                return await FillUserAndPlatform();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public async Task<IActionResult> FillUserAndPlatform()
        {
            try
            {
                var model = new EnquiryCreateViewModel
                {
                    UserTypes = await _userType.GetAllUserTypes(),
                    Platforms = await _enquiryPlatform.GetAllEnquityPlatform(),
                    EnquiryMasters = await _enquiryMaster.GetAllEnquiry(),
                    EnqyiryStatus = await _enquiryStatus.GetAllEnquiryStatus()
                };
                return View(model);
            }   
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEnquiry(EnquiryCreateViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                var model = new EnquiryMasterModel()
                {
                    CompanyName = viewModel.CompanyName,
                    ContactPerson = "-", //viewModel.ContactPerson,
                    ATOL = viewModel.ATOL,
                    IATA = viewModel.IATA,
                    JobTitle = viewModel.JobTitle,
                    ContactEmail = viewModel.ContactEmail,
                    ContactPhone = viewModel.ContactPhone,
                    EnquiryPlatformId = viewModel.PlatformSelectedId, 
                    EnquiryStatusId = 1, //default "In process"
                    UserTypeId = viewModel.UserTypeSelectedId   
                };
                var result = await _enquiryMaster.AddEnquiry(model);
                
            }
            
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> GetFilteredEnquiry(int[] ids)
        {
            try
            {
                var result = await _enquiryMaster.GetFilteredEnquiries(ids);
                return RedirectToAction("Index");
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

        public IActionResult OnClick()
        {
            return PartialView("_EnquiryPartial");
        }


    }
}