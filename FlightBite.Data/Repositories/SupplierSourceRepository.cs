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
    public class SupplierSourceRepository : ISupplierSource
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<SupplierSourceRepository> _logger;

        public SupplierSourceRepository(DatabaseContext context, ILogger<SupplierSourceRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public async Task<IEnumerable<SupplierSourceModel>> GetAllSupplierSource()
        {
            return await _context.SupplierSources.ToListAsync();
        }
    }
}
