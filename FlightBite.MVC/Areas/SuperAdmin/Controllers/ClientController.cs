using System.IO;
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

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> CreateNewClient(ClientCreateViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                List<ClientTermsModel> terms = new List<ClientTermsModel>();
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
                int clientId = model.Id;

                if(viewModel.AvailableTerms != null)
                {
                    foreach (var item in viewModel.AvailableTerms!)
                    {
                        if (item.IsChecked == true)
                        {
                            terms.Add(new ClientTermsModel() { ClientMasterModelId = clientId, TermMasterModelId = item.Id });
                        }
                    }
                }

            }
            return RedirectToAction("Index");
        }

        public async Task<ClientViewModel> FillPrimaryData()
        {
            var TermList = await _termMaster.GetAllTerms();
            var model = new ClientViewModel
            {
                SelectedUserTypes = await FillUserTypes(),
                ClientMasters = await _clientMaster.GetAllClient(),
                AvailableTerms = TermList.Select(vm => new CheckBoxItem()
                {
                    Id = vm.Id,
                    Title = vm.Terms,
                    IsChecked = false
                }).ToList(),
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

        [Obsolete]
        public string ProcessUploadedFile(ClientCreateViewModel model)
        {
            string uniqueFileName = null!;
            if (model.Logo != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "clientLogo");
                FileInfo fileinfo = new FileInfo(model.Logo.FileName);
                string fileExtension = fileinfo.Extension;
                var imagefilename = model.Logo.FileName.Split('.').First();
                uniqueFileName = imagefilename + "_" + Guid.NewGuid().ToString() + fileExtension;

                //uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Logo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
