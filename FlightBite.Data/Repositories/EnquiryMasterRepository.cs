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
            try
            {
                var enquiry = new EnquiryMasterModel()
                {
                    CompanyName = model.CompanyName,
                    ContactPerson = model.ContactPerson,
                    ATOL = model.ATOL,
                    IATA = model.IATA,
                    JobTitle = model.JobTitle,
                    ContactEmail = model.ContactEmail,
                    ContactPhone = model.ContactPhone,
                    EnquiryPlatformId = model.EnquiryPlatformId,
                    EnquiryStatusId = 1,
                    UserTypeId = model.UserTypeId
                };
                context.EnquiryMaster.Add(enquiry);
                context.SaveChanges();
                return enquiry;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public async Task<IEnumerable<EnquiryMasterModel>> GetAllEnquiry()
        {
            try
            {
                IList<EnquiryMasterModel> enquiryMasters = await context.EnquiryMaster.Include(c=>c.EnquiryStatus).ToListAsync();
                return (enquiryMasters);

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
