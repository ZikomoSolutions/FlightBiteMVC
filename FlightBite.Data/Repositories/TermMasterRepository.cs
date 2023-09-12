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
    public class TermMasterRepository : ITermMaster
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<TermMasterRepository> _logger;

        public TermMasterRepository(DatabaseContext context, ILogger<TermMasterRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public async Task<List<TermMasterModel>> GetAllTerms()
        {
            return await _context.TermMasters.ToListAsync();
        }
    }
}
