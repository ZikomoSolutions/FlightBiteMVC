using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlightBite.Data.Repositories
{
    public class EnquiryMasterRepository : IEnquiryMaster
    {
        private readonly DatabaseContext context;

        public EnquiryMasterRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public EnquiryMasterModel AddEnquiry(EnquiryMasterModel model)
        {
            context.EnquiryMaster.Add(model);
            context.SaveChanges();
            return model;
        }

        public async Task<IEnumerable<EnquiryMasterModel>> GetAllEnquiry()
        {
            try
            {
                return await context.EnquiryMaster.ToListAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
            
        }

        public EnquiryMasterModel GetEnquiry(int id)
        {
            return context.EnquiryMaster.Find(id);
        }
    }
}
