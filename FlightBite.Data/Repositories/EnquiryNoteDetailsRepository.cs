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

        public Task DeleteSpecificEnquiryNote(int NoteId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EnquiryNoteDetailsModel>> GetSpecificEnquiryAllNotes(int EnquiryId)
        {
            IEnumerable<EnquiryNoteDetailsModel> enquiryNoteDetails = await _context.EnquiryNoteDetail.Where(c=>c.EnquiryId == EnquiryId).OrderBy(c=>c.CreatedAt).ToListAsync();
            if(enquiryNoteDetails.Count() > 0 )
            {
                return enquiryNoteDetails;
            }
            else
            {
                return null!;
            }
            
        }
    }
}
