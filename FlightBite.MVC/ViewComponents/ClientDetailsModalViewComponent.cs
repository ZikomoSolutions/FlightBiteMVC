using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.ViewComponents
{
    public class ClientDetailsModalViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();  
        }
    }
}
