using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
    public interface IEnquiryNoteDetails
    {
        Task<IEnumerable<EnquiryNoteDetailsModel>> GetSpecificEnquiryAllNotes(int EnquiryId);

        Task<EnquiryNoteDetailsModel> AddSpecificEnquiryNote(EnquiryNoteDetailsModel model);

        Task DeleteSpecificEnquiryNote(int NoteId);
    }
}
