using FlightBite.Data.Models;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class ClientNoteViewModel
    {
        public int ClientId { get; set; }
        public string? ClientNote { get; set; }
        public string? ClientName { get; set; }
        public List<ClientNoteDetailsModel>? ClientNoteDetailsModel { get; set; }
    }
}
