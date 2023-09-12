using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FlightBite.Data.Repositories
{
    public class EnquiryNoteDetailsRepository : IEnquiryNoteDetails
    {
        private readonly DatabaseContext _context;
		private readonly ILogger<EnquiryNoteDetailsRepository> _logger;

		public EnquiryNoteDetailsRepository(DatabaseContext context, ILogger<EnquiryNoteDetailsRepository> logger)
        {
            this._context = context;
			this._logger = logger;
		}
        public async Task<EnquiryNoteDetailsModel> AddSpecificEnquiryNote(EnquiryNoteDetailsModel model)
        {
            try
            {
                var result = await _context.EnquiryNoteDetail.AddAsync(model);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }

        public async Task DeleteSpecificEnquiryNote(int NoteId)
        {
            try
            {
                var UpdateDeleteDate = await _context.EnquiryNoteDetail.FindAsync(NoteId);
                if (UpdateDeleteDate != null)
                {
                    UpdateDeleteDate.DeletedAt = DateTime.Now;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
            }
        }

        public async Task<IEnumerable<EnquiryNoteDetailsModel>> GetAllEnquiryNotes()
        {
            try
            {
                var EnquiryNotes = await _context.EnquiryNoteDetail.Where(p => p.DeletedAt == null).ToListAsync();
                return (EnquiryNotes);
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }

        public List<EnquiryNoteDetailsModel> GetSpecificEnquiryAllNotes(int EnquiryId)
        {
            try
            {
                List<EnquiryNoteDetailsModel> enquiryNoteDetails = _context.EnquiryNoteDetail.Where(c => c.EnquiryMasterModelId == EnquiryId).Where(c => c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToList();
                return enquiryNoteDetails;
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }
    }
}
