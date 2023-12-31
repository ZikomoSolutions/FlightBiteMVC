﻿using FlightBite.Data.Models;
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
        private List<SelectListItem> SelectedUserTypes;

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

        public async Task<List<SelectListItem>> FillUserTypes()
        {
            var UserTypes = await _userType.GetAllUserTypes();
            List<SelectListItem> items = new List<SelectListItem>();    
            foreach (var types in UserTypes)
            {
               items.Add(new SelectListItem(types.Type, types.Id.ToString(),true));
            }
            return items;
        }

        public async Task<IActionResult> FillUserAndPlatform()
        {
            try
            {
                var model = new EnquiryCreateViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
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

        [HttpPost]
        public async Task<IActionResult> Index(List<SelectListItem> UserTypes)
        {
            var SelectedUserType = UserTypes.Where(x => x.Selected).ToList();
            
            if (SelectedUserType.Count() >= 0)
            {
                var result = await _enquiryMaster.GetFilteredEnquiries(SelectedUserType.Select(e=>e.Value).ToList());

                var model = new EnquiryCreateViewModel
                {
                    SelectedUserTypes = await FillUserTypes(),
                    Platforms = await _enquiryPlatform.GetAllEnquityPlatform(),
                    EnquiryMasters = result,
                    EnqyiryStatus = await _enquiryStatus.GetAllEnquiryStatus()
                };

                return View(model);
            }
            else
            {
                return RedirectToAction("Index");
            }

        }

        //public IActionResult EnquiryView(int id)
        //{
        //    //EnquiryMasterModel enquiry = _enquiryMaster.GetEnquiry(id);
        //    //EnquiryCreateViewModel enquiryCreateViewModel = new EnquiryCreateViewModel
        //    //{
        //    //    SelectedEnquiryId = enquiry.Id,
        //    //    CompanyName = enquiry.CompanyName,
        //    //    ContactEmail = enquiry.ContactEmail,
        //    //    ContactPhone = enquiry.ContactPhone,

        //    //};
        //    return RedirectToAction("Index");
         
     
        //}

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