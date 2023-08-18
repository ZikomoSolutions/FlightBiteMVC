using FlightBite.Data.Interfaces;
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
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await _enquiryPlatform.GetAllEnquityPlatform();
            return View(result);
        }
    }
}
