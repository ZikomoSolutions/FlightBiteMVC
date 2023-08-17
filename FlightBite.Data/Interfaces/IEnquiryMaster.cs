using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
    internal interface IEnquiryMaster
    {
        EnquiryMasterModel GetEnquiry(int id);
        IEnumerable<EnquiryMasterModel> GetAllEnquiry();
        EnquiryMasterModel Add(EnquiryMasterModel model);
    }
}
