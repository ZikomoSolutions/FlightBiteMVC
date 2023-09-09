using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightBite.Data.Repositories
{
    public class EnquiryNoteDetailsRepository : IEnquiryNoteDetails
    {
        private readonly DatabaseContext _context;

        public EnquiryNoteDetailsRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public async Task<EnquiryNoteDetailsModel> AddSpecificEnquiryNote(EnquiryNoteDetailsModel model)
        {
            var result = await _context.EnquiryNoteDetail.AddAsync(model);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSpecificEnquiryNote(int NoteId)
        {
            var UpdateDeleteDate = await _context.EnquiryNoteDetail.FindAsync(NoteId);
            if (UpdateDeleteDate != null)
            {
                UpdateDeleteDate.DeletedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<EnquiryNoteDetailsModel>> GetAllEnquiryNotes()
        {
            var EnquiryNotes = await _context.EnquiryNoteDetail.Where(p=>p.DeletedAt == null).ToListAsync();
            return (EnquiryNotes);
        }

        public List<EnquiryNoteDetailsModel> GetSpecificEnquiryAllNotes(int EnquiryId)
        {
            List<EnquiryNoteDetailsModel> enquiryNoteDetails = _context.EnquiryNoteDetail.Where(c=>c.EnquiryMasterModelId == EnquiryId).Where(c=>c.DeletedAt == null).OrderByDescending(c=>c.CreatedAt).ToList();
            return enquiryNoteDetails;
        }
    }
}
