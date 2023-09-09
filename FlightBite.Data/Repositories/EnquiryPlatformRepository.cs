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
    public class EnquiryPlatformRepository : IEnquiryPlatform
    {
        private readonly DatabaseContext _context;

        public EnquiryPlatformRepository(DatabaseContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<EnquiryPlatformModel>> GetAllEnquityPlatform()
        {
            try
            {
                var resutl = await _context.EnquityPlatform.ToListAsync();
                return resutl;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public string GetSpecificPlatform(int id)
        {
            try
            {
                var specificPlatform = _context.EnquityPlatform.FirstOrDefault(s => s.Id == id).PlatForm;
                return specificPlatform;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }
    }
}
