﻿using System.IO;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ClientController : Controller
    {
		private readonly ILogger<HomeController> _logger;
		private readonly IClientMaster _clientMaster;
		private readonly IClientNoteDetails _clientNoteDetails;
        private readonly IUserType _userType;
        private readonly ISupplierSource _supplierSource;
        private readonly ITermMaster _termMaster;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public ClientController(ILogger<HomeController> logger, IClientMaster clientMaster, IClientNoteDetails clientNoteDetails, IUserType userType,
                                ISupplierSource supplierSource, ITermMaster termMaster, IHostingEnvironment hostingEnvironment)
        {
			this._logger = logger;
			this._clientMaster = clientMaster;
			this._clientNoteDetails = clientNoteDetails;
            this._userType = userType;
            this._supplierSource = supplierSource;
            this._termMaster = termMaster;
            this._hostingEnvironment = hostingEnvironment;
        }
        public async Task<IActionResult> Index()
        {
            var result = await FillPrimaryData();

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

                var result = await _clientMaster.GetFilteredClients(SelectedUserType.Select(e => e.Value).ToList(), ordername);

                var SortByItemsList = FillSortByItems();
                ViewBag.SortByItemsList = SortByItemsList;

                var model = new ClientViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
                    ClientMasters = result
                };
                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult NoteView(int ClientId)
        {
            var NoteList = _clientNoteDetails.GetSpecificClientAllNotes(ClientId);
            var ClientName = _clientMaster.GetSpecificClientName(ClientId);
            ClientNoteViewModel model = new ClientNoteViewModel()
            {
                ClientId = ClientId,
                ClientName = ClientName,
                ClientNoteDetailsModel = NoteList,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> NoteView(int ClientId, ClientNoteViewModel model)
        {
            if (ModelState.IsValid)
            {
                var AddInModel = new ClientNoteDetailsModel
                {
                    ClientMasterModelId = model.ClientId,
                    Note = model.ClientNote,
                    CreatedAt = DateTime.Now,
                };
                var result = await _clientNoteDetails.AddSpecificClientNote(AddInModel);
            }

            ModelState.Remove("ClientNote");

            var NoteList = _clientNoteDetails.GetSpecificClientAllNotes(ClientId);
            var ClientName = _clientMaster.GetSpecificClientName(ClientId);
            ClientNoteViewModel vmodel = new ClientNoteViewModel()
            {
                ClientId = ClientId,
                ClientName = ClientName,
                ClientNoteDetailsModel = NoteList,
            };
            return View(vmodel);
        }

        public async Task<IActionResult> DeleteNote(int NoteId, int ClientId)
        {
            await _clientNoteDetails.DeleteSpecificClientNote(NoteId);

            var NoteList = _clientNoteDetails.GetSpecificClientAllNotes(NoteId);
            var ClientName = _clientMaster.GetSpecificClientName(ClientId);
            ClientNoteViewModel vmodel = new ClientNoteViewModel()
            {
                ClientId = ClientId,
                ClientName = ClientName,
                ClientNoteDetailsModel = NoteList,
            };
            return View("NoteView", vmodel);
        }

        public async Task<IActionResult> CreateNewClient()
		{
            var UserTypeList = await _userType.GetAllUserTypes();
            var SupplierSourceList = await _supplierSource.GetAllSupplierSource();
            var TermList = await _termMaster.GetAllTerms();
            ClientCreateViewModel model = new ClientCreateViewModel()
            {
                UserTypes = UserTypeList,
                SupplierSourceModels = SupplierSourceList,
            };
            model.AvailableTerms = TermList.Select(vm => new CheckBoxItem()
            {
                Id = vm.Id,
                Title = vm.Terms,
                IsChecked = false
            }).ToList();
			return View(model);
		}

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> CreateNewClient(ClientCreateViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(viewModel);
                var model = new ClientMasterModel()
                {
                    CompanyName = viewModel.CompanyName,
                    ContactPerson = "-",
                    VATNumber = viewModel.VATNumber,
                    RegisterationNo = viewModel.RegisterationNo,
                    AccountHolder = viewModel.AccountHolder,
                    JobTitle = viewModel.JobTitle,
                    ContactEmail = viewModel.ContactEmail,
                    ATOL = viewModel.ATOL,
                    IATA = viewModel.IATA,
                    PTS = viewModel.PTS,
                    TTA = viewModel.TTA,
                    Other = viewModel.Other,
                    ContactPhone = viewModel.ContactPhone,
                    LogoPath = uniqueFileName,
                    UserTypesModelId = viewModel.UserTypeSelectedId,
                    SupplierSourceModelId = viewModel.SupplierSourceModelId

                };
                var result = await _clientMaster.AddClient(model);
            }
            return RedirectToAction("Index");
        }

        public async Task<ClientViewModel> FillPrimaryData()
        {
            var model = new ClientViewModel
            {
                SelectedUserTypes = await FillUserTypes(),
                ClientMasters = await _clientMaster.GetAllClient(),
            };
            return model;
        }
        public List<SelectListItem> FillSortByItems()
        {
            List<SelectListItem> items = new List<SelectListItem>();
            {
                items.Add(new SelectListItem { Value = "Select One...", Text = "Select One..." });
                items.Add(new SelectListItem { Value = "Client Name Ascending", Text = "Client Name Ascending" });
                items.Add(new SelectListItem { Value = "Date Wise Ascending", Text = "Date Wise Ascending" });
                items.Add(new SelectListItem { Value = "Date Wise Descending", Text = "Date Wise Descending" });
            }
            return items;
        }
        public async Task<List<SelectListItem>> FillUserTypes()
        {
            var UserTypes = await _userType.GetAllUserTypes();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var types in UserTypes)
            {
                items.Add(new SelectListItem(types.UserType, types.Id.ToString(), true));
            }
            return items;
        }

        public async Task<List<SelectListItem>> FillTermList()
        {
            var TermLists = await _termMaster.GetAllTerms();
            List<SelectListItem> terms = new List<SelectListItem>();
            foreach (var item in TermLists)
            {
                terms.Add(new SelectListItem(item.Terms, item.Id.ToString()));
            }
            return terms;
        }

        [Obsolete]
        public string ProcessUploadedFile(ClientCreateViewModel model)
        {
            string uniqueFileName = null!;
            //if the photo property on the incoming model object is not null, then the user
            //has selected an image to upload.
            if (model.Logo != null)
            {
                //the image must be uploaded to the images folder in wwwroot
                //to get the path of the wwwroot folder we are using the inject
                //HostingEnvironment service provided by ASP.net core
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "clientLogo");
                //To make sure the file name is unique we are appending a new
                //GUID_value and an underscore to the file name

                FileInfo fileinfo = new FileInfo(model.Logo.FileName);
                string fileExtension = fileinfo.Extension;

                //var fileextension = model.Logo.FileName.Split('.').Last();
                var imagefilename = model.Logo.FileName.Split('.').First();
                uniqueFileName = imagefilename + "_" + Guid.NewGuid().ToString() + fileExtension;

                //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //Use CopyTo() method provided by IFormFile interface to
                //copy the file to wwwroot-->clientLogo folder
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Logo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
