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
        private List<SelectListItem> SelectSortByItems;

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

            var SortByItemsList = FillSortByItems();
            ViewBag.SortByItemsList = SortByItemsList;

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Index(List<SelectListItem> UserTypes, string SortOrder)
        {
            var SelectedUserType = UserTypes.Where(x => x.Selected).ToList();
            if (SelectedUserType.Count() >= 0)
            {
                var result = await _enquiryMaster.GetFilteredEnquiries(SelectedUserType.Select(e => e.Value).ToList(), null) ;
				var EnquiryStatusList = FillEnquiryStatus();
				ViewBag.EnquiryStatusList = EnquiryStatusList;

				var model = new EnquiryMasterViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
                    Platforms = await _enquiryPlatform.GetAllEnquityPlatform(),
                    EnquiryMasters = result
    				//EnqyiryStatus = _enquiryStatus.GetAllEnquiryStatus()
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

        public List<SelectListItem> FillSortByItems()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            {
                items.Add(new SelectListItem { Value = "0", Text = "Select One..." });
                items.Add(new SelectListItem { Value = "1", Text = "Company Name" });
                items.Add(new SelectListItem { Value = "2", Text = "Date Wise Ascending" });
                items.Add(new SelectListItem { Value = "3", Text = "Date Wise Descending" });
            }
            return items;
        }

        public  List<SelectListItem> FillEnquiryStatus()
        {
            var EnquiryStatus =  _enquiryStatus.GetAllEnquiryStatus();
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
                EnquiryMasters = await _enquiryMaster.GetAllEnquiry(),
                EnquiryNoteDetailsModel = await _enquiryNoteDetails.GetAllEnquiryNotes()
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
                    EnquiryPlatformModelId = viewModel.PlatformSelectedId,
                    EnquiryStatusModelId = 1,
                    UserTypesModelId = viewModel.UserTypeSelectedId
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

        public IActionResult NotesDetail(int EnquiryId)
        {

            var EnquiryNotes = _enquiryNoteDetails.GetSpecificEnquiryAllNotes(EnquiryId);
            var EnquiryMaster = _enquiryMaster.GetEnquiry(EnquiryId);

            var model = new EnquiryMasterModel
            {
                EnquiryNoteDetailsModel = EnquiryNotes,

                Id = EnquiryMaster.Id,
                CompanyName = EnquiryMaster.CompanyName,
                ContactPerson = EnquiryMaster.ContactPerson, 
                ATOL = EnquiryMaster.ATOL,
                IATA = EnquiryMaster.IATA,
                JobTitle = EnquiryMaster.JobTitle,
                ContactEmail = EnquiryMaster.ContactEmail,
                ContactPhone = EnquiryMaster.ContactPhone,
                EnquiryPlatformModelId = EnquiryMaster.EnquiryPlatformModelId,
                EnquiryStatusModelId = EnquiryMaster.EnquiryStatusModelId,
                UserTypesModelId = EnquiryMaster.UserTypesModelId
            };
            //return PartialView("_NotesDetailPartial", model);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AddNotes(int EnquiryId, EnquiryNoteViewModel model)
        {
            if(ModelState.IsValid)
            {
                var AddInModel = new EnquiryNoteDetailsModel
                {
                    EnquiryMasterModelId = model.EnquiryId,
                    Note = model.EnquiryNote,
                    CreatedAt = DateTime.Now,
                };
                var result = await _enquiryNoteDetails.AddSpecificEnquiryNote(AddInModel);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteNote(int NoteId)
        {
            await _enquiryNoteDetails.DeleteSpecificEnquiryNote(NoteId);
            return RedirectToAction("Index");
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