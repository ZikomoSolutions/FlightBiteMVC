using FlightBite.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.ViewComponents
{
    public class NotesViewComponent : ViewComponent
    {
        private readonly IEnquiryNoteDetails _enquiryNoteDetails;

        public NotesViewComponent(IEnquiryNoteDetails enquiryNoteDetails)
        {
            this._enquiryNoteDetails = enquiryNoteDetails;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var result = _enquiryNoteDetails.GetSpecificEnquiryAllNotes(id);

            return View(result);
        }
    }
}
