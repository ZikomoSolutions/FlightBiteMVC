﻿using System;
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
    public class UserTypeRepository : IUserType
    {
        private readonly DatabaseContext _context;
        private readonly ILogger<UserTypeRepository> _logger;

        public UserTypeRepository(DatabaseContext context, ILogger<UserTypeRepository> logger)
        {
            this._context = context;
            this._logger = logger;
        }
        public async Task<IEnumerable<UserTypesModel>> GetAllUserTypes()
        {
            return await _context.UserType.ToListAsync();
        }
    }
}
