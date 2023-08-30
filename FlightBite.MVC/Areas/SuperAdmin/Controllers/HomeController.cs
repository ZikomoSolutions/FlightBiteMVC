using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using FlightBite.Data;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.Rendering;
using Azure;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly IEnquiryMaster _enquiryMaster;
        private readonly IUserType _userType;
        private readonly IEnquiryPlatform _enquiryPlatform;
        private readonly IEnquiryStatus _enquiryStatus;
        private readonly IEnquiryNoteDetails _enquiryNoteDetails;
        private List<SelectListItem> SelectedUserTypes;

        public HomeController(IEnquiryMaster enquiryMaster, IUserType userType, IEnquiryPlatform enquiryPlatform, IEnquiryStatus enquiryStatus,
                              IEnquiryNoteDetails enquiryNoteDetails)
        {
            this._enquiryMaster = enquiryMaster;
            this._userType = userType;
            this._enquiryPlatform = enquiryPlatform;
            this._enquiryStatus = enquiryStatus;
            this._enquiryNoteDetails = enquiryNoteDetails;
        }

        public async Task<IActionResult> Index()
        {
            var result = await FillUserAndPlatform();
            var EnquiryStatusList = FillEnquiryStatus();
            ViewBag.EnquiryStatusList = EnquiryStatusList;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Index(List<SelectListItem> UserTypes)
        {
            var SelectedUserType = UserTypes.Where(x => x.Selected).ToList();

            if (SelectedUserType.Count() >= 0)
            {
                var result = await _enquiryMaster.GetFilteredEnquiries(SelectedUserType.Select(e => e.Value).ToList());

                var model = new EnquiryMasterViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
                    Platforms = await _enquiryPlatform.GetAllEnquityPlatform(),
                    EnquiryMasters = result,
                    EnqyiryStatus = _enquiryStatus.GetAllEnquiryStatus()
                };

                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        public async Task<List<SelectListItem>> FillUserTypes()
        {
            var UserTypes = await _userType.GetAllUserTypes();
            List<SelectListItem> items = new List<SelectListItem>();    
            foreach (var types in UserTypes)
            {
               items.Add(new SelectListItem(types.UserType, types.Id.ToString(),true));
            }
            return items;
        }

        public List<SelectListItem> FillEnquiryStatus()
        {
            var EnquiryStatus = _enquiryStatus.GetAllEnquiryStatus();
            List<SelectListItem> StatusList = new List<SelectListItem>();
            foreach ( var status in EnquiryStatus)
            {
                StatusList.Add(new SelectListItem { Text = status.Status, Value = status.Id.ToString() });
            }
            return StatusList;
        }

        public async Task<EnquiryMasterViewModel> FillUserAndPlatform()
        {
            var model = new EnquiryMasterViewModel
            {
                SelectedUserTypes = await FillUserTypes(),
                Platforms = await _enquiryPlatform.GetAllEnquityPlatform(),
                EnquiryMasters = await _enquiryMaster.GetAllEnquiry()
                //EnqyiryStatus = _enquiryStatus.GetAllEnquiryStatus(),
            };
            return model;
        }

        [HttpPost]
        public async Task<IActionResult> AddEnquiry(EnquiryMasterViewModel viewModel)
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
        
        public async Task<IActionResult> UpdateStatus(EnquiryMasterModel model)
        {
            await _enquiryMaster.UpdateStatus(model);
            return RedirectToAction("Index");
        }

        public IActionResult NotesDetail(int id)
        {

            return RedirectToAction("index");
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