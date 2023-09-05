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
        private IEnumerable<EnquiryMasterModel> enquiries;

        public EnquiryMasterRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public async Task<EnquiryMasterModel> AddEnquiry(EnquiryMasterModel model)
        {
            try
            {
                var result = await context.EnquiryMaster.AddAsync(model);
                await context.SaveChangesAsync();
                return result.Entity;
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
                IList<EnquiryMasterModel> enquiryMasters = await context.EnquiryMaster.Include(c=>c.EnquiryStatusModel).OrderByDescending(c=>c.CreatedAt).ToListAsync();
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

        public async Task<IEnumerable<EnquiryMasterModel>> GetFilteredEnquiries(List<string> UserIds, string SortOrder)
        {
            try
            {

                switch (SortOrder)
                {
                    case "Company Name Ascending":
                        enquiries = await context.EnquiryMaster.OrderBy(e => e.CompanyName).ToListAsync();
                        break;
                    case "Date Wise Ascending":
                        enquiries = await context.EnquiryMaster.OrderBy(e => e.CreatedAt).AsNoTracking().ToListAsync();
                        break;
                    case "Date Wise Descending":
                        enquiries = await context.EnquiryMaster.OrderByDescending(e => e.CreatedAt).ToListAsync();
                        break;
                    default:
                        enquiries = await context.EnquiryMaster.Where(e => UserIds.Contains(e.UserTypesModelId.ToString())).OrderByDescending(e => e.CreatedAt).ToListAsync();
                        break;
                }
                
                return (enquiries);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }

        public async Task UpdateStatus(EnquiryMasterModel model)
        {
            var status = await context.EnquiryMaster.FindAsync(model.Id);
            if(status != null)
            {
                status.EnquiryStatusModelId = model.EnquiryStatusModelId;
                status.UpdatedAt = DateTime.Now;
                await context.SaveChangesAsync();
            }
        }
    }
}
