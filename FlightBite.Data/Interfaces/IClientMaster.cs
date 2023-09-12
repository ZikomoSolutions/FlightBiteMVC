using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
	public interface IClientMaster
	{
		Task<ClientMasterModel> GetParticularClient(int ClientId);
		Task<IEnumerable<ClientMasterModel>> GetAllClient();
		Task<ClientMasterModel> AddClient(ClientMasterModel model);
		Task<IEnumerable<ClientMasterModel>> GetFilteredClients(List<string> UserIds, string SortOrder);
		string GetSpecificClientName(int ClientId);
	}
}
