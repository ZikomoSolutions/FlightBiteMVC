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
	public class ClientMasterRepository : IClientMaster
	{
		private readonly DatabaseContext _context;
		private readonly ILogger<ClientMasterRepository> _logger;
		private IEnumerable<ClientMasterModel>? clients;

		public ClientMasterRepository(DatabaseContext context, ILogger<ClientMasterRepository> logger)
        {
			this._context = context;
			this._logger = logger;
		}
        public async Task<ClientMasterModel> AddClient(ClientMasterModel model)
		{
			try
			{
				var result = await _context.ClientMasters.AddAsync(model);
				await _context.SaveChangesAsync();
				return result.Entity;
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public async Task<IEnumerable<ClientMasterModel>> GetAllClient()
		{
			try
			{
				return await _context.ClientMasters.OrderByDescending(c => c.CreatedAt).ToListAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public async Task<IEnumerable<ClientMasterModel>> GetFilteredClients(List<string> UserIds, string SortOrder)
		{
			try
			{
				switch (SortOrder)
				{
					case "Client Name Ascending":
						clients = await _context.ClientMasters.OrderBy(e => e.CompanyName).AsNoTracking().ToListAsync();
						break;
					case "Date Wise Ascending":
						clients = await _context.ClientMasters.OrderBy(e => e.CreatedAt).AsNoTracking().ToListAsync();
						break;
					case "Date Wise Descending":
						clients = await _context.ClientMasters.OrderByDescending(e => e.CreatedAt).AsNoTracking().ToListAsync();
						break;
					default:
						clients = await _context.ClientMasters.Where(e => UserIds.Contains(e.UserTypesModelId.ToString())).OrderByDescending(e => e.CreatedAt).AsNoTracking().ToListAsync();
                        break;
				}

				return (clients);
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public async Task<ClientMasterModel> GetParticularClient(int ClientId)
		{
			try
			{
				return await _context.ClientMasters.FirstOrDefaultAsync(i => i.Id == ClientId);
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}

		public string GetSpecificClientName(int ClientId)
		{
			try
			{
				var companyname = "Client Name";
				if (ClientId != 0)
				{
					companyname = _context.ClientMasters.FirstOrDefault(e => e.Id == ClientId)!.CompanyName;
				}
				return companyname!;
			}
			catch (Exception ex)
			{
				_logger.LogError(new EventId(), ex, ex.Message);
				return null!;
			}
		}
	}
}
