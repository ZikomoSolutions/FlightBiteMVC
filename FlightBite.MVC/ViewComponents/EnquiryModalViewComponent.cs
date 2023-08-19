using FlightBite.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
namespace FlightBite.MVC.ViewComponents
{
    public class EnquiryModalViewComponent : ViewComponent
    {

        //public IViewComponentResult InvokeAsync()
        //{
        //    return View("Default");
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //return View("Default",UserName);
            return View("Default");
        }
    }
}
