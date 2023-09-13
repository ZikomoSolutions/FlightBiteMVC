using FlightBite.Data.Models;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using FlightBite.Data;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc.Rendering;
using Azure;
using Microsoft.Data.SqlClient;
using System.Collections.Immutable;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnquiryMaster _enquiryMaster;
        private readonly IUserType _userType;
        private readonly IEnquiryPlatform _enquiryPlatform;
        private readonly IEnquiryStatus _enquiryStatus;
        private readonly IEnquiryNoteDetails _enquiryNoteDetails;
        private readonly IEnumerable<EnquiryMasterModel> result;
        private List<SelectListItem>? SelectedUserTypes;
        private List<SelectListItem>? SelectSortByItems;

        public HomeController(IEnquiryMaster enquiryMaster, IUserType userType, IEnquiryPlatform enquiryPlatform, IEnquiryStatus enquiryStatus,
                              IEnquiryNoteDetails enquiryNoteDetails, ILogger<HomeController> logger)
        {
            this._enquiryMaster = enquiryMaster;
            this._userType = userType;
            this._enquiryPlatform = enquiryPlatform;
            this._enquiryStatus = enquiryStatus;
            this._enquiryNoteDetails = enquiryNoteDetails;
            this._logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var result = await FillPrimaryData();

            var EnquiryStatusList = FillEnquiryStatus();
            ViewBag.EnquiryStatusList = EnquiryStatusList;

            var SortByItemsList = FillSortByItems();
            ViewBag.SortByItemsList = SortByItemsList;

            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> Index(List<SelectListItem> UserTypes, IFormCollection formCollection)
        {
            string ordername = formCollection["SortName"]!;
            var SelectedUserType = UserTypes.Where(x => x.Selected).ToList();
            if (SelectedUserType.Count() >= 0)
            {

                var result = await _enquiryMaster.GetFilteredEnquiries(SelectedUserType.Select(e => e.Value).ToList(), ordername);
				var EnquiryStatusList = FillEnquiryStatus();
				ViewBag.EnquiryStatusList = EnquiryStatusList;

                var SortByItemsList = FillSortByItems();
                ViewBag.SortByItemsList = SortByItemsList;

				var PlatFormList = await _enquiryPlatform.GetAllEnquityPlatform();

				var model = new EnquiryViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
                    Platforms = PlatFormList,
                    EnquiryMasters = result
			    };
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public async Task<IActionResult> EnquiryView(int id)
        {
            var enquiryView = await _enquiryMaster.GetEnquiry(id);
			
            var EnquiryStatusList = FillEnquiryStatus();
			ViewBag.EnquiryStatusList = EnquiryStatusList;
			
            var statusList = _enquiryStatus.GetAllEnquiryStatus();
            
            EnquiryInfoViewModel model = new EnquiryInfoViewModel()
            {
                Id = id,
                CompanyName = enquiryView.CompanyName,
                ContactPerson = enquiryView.ContactPerson,
                JobTitle = enquiryView.JobTitle,
                ContactPhone = enquiryView.ContactPhone,
                ContactEmail = enquiryView.ContactEmail,
                ATOL = enquiryView.ATOL,
                IATA = enquiryView.IATA,
                PlatForm = enquiryView.EnquiryPlatformModel?.PlatForm,
                EnquiryStatus = statusList,
                EnquiryStatusModelId = enquiryView.EnquiryStatusModelId,
            };
            return View(model);
        }

		public async Task<IActionResult> UpdateStatus(EnquiryMasterModel model)
		{
			await _enquiryMaster.UpdateStatus(model);
			return RedirectToAction("Index");
		}

   //     public async Task<IActionResult> UserTypeView()
   //     {
   //         var UserType = await _userType.GetAllUserTypes();
   //         EnquiryCreateViewModel model = new EnquiryCreateViewModel()
   //         {
   //             UserTypes = UserType,
   //         };
			//return View(model);
   //     }

  //      [HttpGet]
		//public async Task<IActionResult> AddEnquiryView()
  //      {
  //          var PlatFormList = await _enquiryPlatform.GetAllEnquityPlatform();
  //          EnquiryCreateViewModel model = new EnquiryCreateViewModel()
  //          {
  //              Platforms = PlatFormList,
  //          };

		//	return View("AddEnquiry",model);
  //      }

        [HttpPost]
        public async Task<IActionResult> AddEnquiry(EnquiryViewModel viewModel)
        {

			if (ModelState.IsValid)
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
                int eid = model.Id;
            }
    //        else
    //        {
    //            var PlatFormList = await _enquiryPlatform.GetAllEnquityPlatform();
    //            var model = new EnquiryCreateViewModel()
    //            {
    //                Platforms = PlatFormList,
    //            };

				//return View(model);

    //        }
            return RedirectToAction("Index");

		}

        public IActionResult NoteView(int EnquiryId)
        {
            var NoteList = _enquiryNoteDetails.GetSpecificEnquiryAllNotes(EnquiryId);
            var CompanyName = _enquiryMaster.GetSpecificCompanyName(EnquiryId);
            EnquiryNoteViewModel model = new EnquiryNoteViewModel()
            {
                EnquiryId = EnquiryId,
                CompanyName = CompanyName,
                EnquiryNoteDetailsModel = NoteList,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NoteView(int EnquiryId, EnquiryNoteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var AddInModel = new EnquiryNoteDetailsModel
                {
                    EnquiryMasterModelId = model.EnquiryId,
                    Note = model.EnquiryNote,
                    CreatedAt = DateTime.Now,
                };
                var result = await _enquiryNoteDetails.AddSpecificEnquiryNote(AddInModel);
            }

            ModelState.Remove("EnquiryNote");

			var NoteList = _enquiryNoteDetails.GetSpecificEnquiryAllNotes(EnquiryId);
			var CompanyName = _enquiryMaster.GetSpecificCompanyName(EnquiryId);
			EnquiryNoteViewModel vmodel = new EnquiryNoteViewModel()
			{
				EnquiryId = EnquiryId,
				CompanyName = CompanyName,
				EnquiryNoteDetailsModel = NoteList,
			};
			return View(vmodel);
        }

        public async Task<IActionResult> DeleteNote(int NoteId, int EnquiryId)
        {
            await _enquiryNoteDetails.DeleteSpecificEnquiryNote(NoteId);

            var NoteList = _enquiryNoteDetails.GetSpecificEnquiryAllNotes(EnquiryId);
            var CompanyName = _enquiryMaster.GetSpecificCompanyName(EnquiryId);
            EnquiryNoteViewModel vmodel = new EnquiryNoteViewModel()
            {
                EnquiryId = EnquiryId,
                CompanyName = CompanyName,
                EnquiryNoteDetailsModel = NoteList,
            };
            return View("NoteView", vmodel);
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
                items.Add(new SelectListItem { Value = "Select One...", Text = "Select One..." });
                items.Add(new SelectListItem { Value = "Company Name Ascending", Text = "Company Name Ascending" });
                items.Add(new SelectListItem { Value = "Date Wise Ascending", Text = "Date Wise Ascending" });
                items.Add(new SelectListItem { Value = "Date Wise Descending", Text = "Date Wise Descending" });
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

        public async Task<EnquiryViewModel> FillPrimaryData()
        {
			var PlatFormList = await _enquiryPlatform.GetAllEnquityPlatform();
			var model = new EnquiryViewModel
            {
                SelectedUserTypes = await FillUserTypes(),
                Platforms = PlatFormList,
				EnquiryMasters = await _enquiryMaster.GetAllEnquiry(),
            };
            return model;
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