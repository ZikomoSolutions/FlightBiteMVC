using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class ClientViewModel
    {
        public List<SelectListItem>? SelectedUserTypes { get; set; }
        public IEnumerable<ClientMasterModel>? ClientMasters { get; set; }
    }
}
