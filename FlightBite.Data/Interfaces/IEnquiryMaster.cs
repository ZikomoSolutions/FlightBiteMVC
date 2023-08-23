using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
    public interface IEnquiryMaster
    {
        EnquiryMasterModel GetEnquiry(int id);
        Task<IEnumerable<EnquiryMasterModel>> GetAllEnquiry();
        Task<EnquiryMasterModel> AddEnquiry(EnquiryMasterModel model);

        Task<IEnumerable<EnquiryMasterModel>> GetFilteredEnquiries(int UserTypeIds);
    }
}
