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
	public class ClientNoteDetailsRepository : IClientNoteDetails
	{
		private readonly DatabaseContext _context;
		private readonly ILogger<ClientNoteDetailsRepository> _logger;

		public ClientNoteDetailsRepository(DatabaseContext context, ILogger<ClientNoteDetailsRepository> logger)
        {
			this._context = context;
			this._logger = logger;
		}
        public async Task<ClientNoteDetailsModel> AddSpecificClientNote(ClientNoteDetailsModel model)
		{
			try
			{
				var result = await _context.ClientNoteDetails.AddAsync(model);
				await _context.SaveChangesAsync();
				return result.Entity;
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public async Task DeleteSpecificClientNote(int NoteId)
		{
			try
			{
				var UpdateDeleteDate = await _context.ClientNoteDetails.FindAsync(NoteId);
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

		public async Task<IEnumerable<ClientNoteDetailsModel>> GetAllClientNotes()
		{
			try
			{
				var ClientNotes = await _context.ClientNoteDetails.Where(p => p.DeletedAt == null).ToListAsync();
				return (ClientNotes);
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public List<ClientNoteDetailsModel> GetSpecificClientAllNotes(int ClientId)
		{
			try
			{
				List<ClientNoteDetailsModel> clientNoteDetails = _context.ClientNoteDetails.Where(c => c.ClientMasterModelId == ClientId).Where(c => c.DeletedAt == null).OrderByDescending(c => c.CreatedAt).ToList();
				return clientNoteDetails;
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}
	}
}
