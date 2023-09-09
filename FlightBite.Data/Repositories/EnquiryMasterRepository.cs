using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using FlightBite.Data.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

namespace FlightBite.Data.Repositories
{
    public class EnquiryMasterRepository : IEnquiryMaster
    {
        private readonly ILogger<EnquiryMasterRepository> _logger;
        private readonly DatabaseContext _context;
        private IEnumerable<EnquiryMasterModel>? enquiries;

        public EnquiryMasterRepository(DatabaseContext context, ILogger<EnquiryMasterRepository> logger)
        {
            this._context = context;
			this._logger = logger;
		}
        public async Task<EnquiryMasterModel> AddEnquiry(EnquiryMasterModel model)
        {
            try
            {
                var result = await _context.EnquiryMaster.AddAsync(model);
                await _context.SaveChangesAsync();
                return result.Entity;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null!;
            }
        }
		public  async Task<EnquiryMasterModel> GetEnquiry(int id)
		{
            try
            {
                return await _context.EnquiryMaster.Include(e=>e.EnquiryPlatformModel).Include(s=>s.EnquiryStatusModel).FirstOrDefaultAsync(i=>i.Id == id);
			}
			catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
		}

		public async Task<IEnumerable<EnquiryMasterModel>> GetAllEnquiry()
        {
            try
            {
                return await _context.EnquiryMaster.Include(c=>c.EnquiryStatusModel).OrderByDescending(c=>c.CreatedAt).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }

        public async Task<IEnumerable<EnquiryMasterModel>> GetFilteredEnquiries(List<string> UserIds, string SortOrder)
        {
            try
            {
                switch (SortOrder)
                {
                    case "Company Name Ascending":
                        enquiries = await _context.EnquiryMaster.Include(e => e.EnquiryStatusModel).OrderBy(e => e.CompanyName).AsNoTracking().ToListAsync();
                        break;
                    case "Date Wise Ascending":
                        enquiries = await _context.EnquiryMaster.Include(e => e.EnquiryStatusModel).OrderBy(e => e.CreatedAt).AsNoTracking().ToListAsync();
                        break;
                    case "Date Wise Descending":
                        enquiries = await _context.EnquiryMaster.Include(e => e.EnquiryStatusModel).OrderByDescending(e => e.CreatedAt).AsNoTracking().ToListAsync();
                        break;
                    default:
                        enquiries = await _context.EnquiryMaster.Include(e => e.EnquiryStatusModel).Where(e => UserIds.Contains(e.UserTypesModelId.ToString())).OrderByDescending(e => e.CreatedAt).AsNoTracking().ToListAsync();
                        break;
                }
                
                return (enquiries);
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
        }

        public async Task UpdateStatus(EnquiryMasterModel model)
        {
            var status = await _context.EnquiryMaster.FindAsync(model.Id);
            if(status != null)
            {
                status.EnquiryStatusModelId = model.EnquiryStatusModelId;
                status.UpdatedAt = DateTime.Now;
                await _context.SaveChangesAsync();
            }
        }

		public string GetSpecificCompanyName(int EnquiryId)
		{
            try
            {
                var companyname = "Company Name";
                if (EnquiryId != 0)
                {
                   companyname = _context.EnquiryMaster.FirstOrDefault(e => e.Id == EnquiryId)!.CompanyName;
                }
                return companyname!;
            }
            catch (Exception ex)
            {
                _logger.LogError(new EventId(), ex, ex.Message);
                return null!;
            }
		}
	}
}
