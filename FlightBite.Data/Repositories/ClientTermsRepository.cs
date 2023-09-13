using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;

namespace FlightBite.Data.Repositories
{
    public class ClientTermsRepository : IClientTerms
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<ClientTermsRepository> _logger;

        public ClientTermsRepository(DatabaseContext context, ILogger<ClientTermsRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public  List<ClientTermsModel> SaveSelectedTerms(List<ClientTermsModel> terms)
        {
            try
            {
                //EntityEntry<ClientTermsModel> result = _context.ClientTerms.Add(terms);
                // _context.SaveChangesAsync();
                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }
    }
}
