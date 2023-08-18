using FlightBite.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace FlightBite.MVC.ViewComponents
{
    
    public class HelloViewComponent:ViewComponent
    {
        //public HelloViewComponent()
        //{
            
        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //return View("Default",UserName);
            return View<string>("Default");
        }
    }
}
