using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;

namespace FlightBite.Data.Repositories
{
    public class EnquiryMasterRepository : IEnquiryMaster
    {
        private readonly DatabaseContext context;

        public EnquiryMasterRepository(DatabaseContext context)
        {
            this.context = context;
        }
        public EnquiryMasterModel Add(EnquiryMasterModel model)
        {
            context.EnquiryMaster.Add(model);
            context.SaveChanges();
            return model;
        }

        public IEnumerable<EnquiryMasterModel> GetAllEnquiry()
        {
            return context.EnquiryMaster;
        }

        public EnquiryMasterModel GetEnquiry(int id)
        {
            return context.EnquiryMaster.Find(id);
        }
    }
}
