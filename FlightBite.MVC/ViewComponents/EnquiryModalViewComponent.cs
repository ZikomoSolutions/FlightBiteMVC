using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using FlightBite.MVC.Areas.SuperAdmin.ViewModels;
using FlightBite.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
namespace FlightBite.MVC.ViewComponents
{
    public class EnquiryModalViewComponent : ViewComponent
    {
        private readonly IEnquiryPlatform _enquiryPlatform;

        public EnquiryModalViewComponent(IEnquiryPlatform enquiryPlatform)
        {
            this._enquiryPlatform = enquiryPlatform;
        }
        //public IViewComponentResult InvokeAsync()
        //{
        //    return View("Default");
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            EnquiryCreateViewModel model = new();
            return View(model);
            //var result = await _enquiryPlatform.GetAllEnquityPlatform();
            //return View(result);
        }
    }
}
