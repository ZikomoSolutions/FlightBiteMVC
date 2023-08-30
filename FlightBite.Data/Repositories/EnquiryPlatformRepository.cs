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
        private readonly DatabaseContext context;

        public EnquiryPlatformRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<EnquiryPlatformModel>> GetAllEnquityPlatform()
        {
            try
            {
                var resutl = await context.EnquityPlatform.ToListAsync();
                return resutl;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public  string GetSpecificPlatform(int id)
        {
            try
            {
                var specificPlatform = context.EnquityPlatform.FirstOrDefault(s => s.Id == id).PlatForm;
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
