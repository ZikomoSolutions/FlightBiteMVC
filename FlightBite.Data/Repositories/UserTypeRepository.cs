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
    public class UserTypeRepository : IUserType
    {
        private readonly DatabaseContext _context;

        public UserTypeRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<UserTypesModel>> GetAllUserTypes()
        {
            return await _context.UserType.ToListAsync();
        }
    }
}
