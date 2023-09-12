using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
	public interface IClientNoteDetails
	{
		List<ClientNoteDetailsModel> GetSpecificClientAllNotes(int ClientId);

		Task<ClientNoteDetailsModel> AddSpecificClientNote(ClientNoteDetailsModel model);

		Task DeleteSpecificClientNote(int NoteId);

		Task<IEnumerable<ClientNoteDetailsModel>> GetAllClientNotes();
	}
}
