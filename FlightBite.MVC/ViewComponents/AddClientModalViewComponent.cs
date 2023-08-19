using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.ViewComponents
{
    public class AddClientModalViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("Default");
        }

    }
}
