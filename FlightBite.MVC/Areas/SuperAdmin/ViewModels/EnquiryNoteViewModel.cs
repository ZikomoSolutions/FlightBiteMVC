using FlightBite.Data.Models;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class EnquiryNoteViewModel
    {
        public int EnquiryId { get; set; }
        public string? EnquiryNote { get; set; }

        public List<EnquiryNoteDetailsModel>? EnquiryNoteDetailsModel { get; set; }
    }
}
