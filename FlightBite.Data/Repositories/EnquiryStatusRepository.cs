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
    public class EnquiryStatusRepository : IEnquiryStatus
    {
        private readonly DatabaseContext _context;

        public EnquiryStatusRepository(DatabaseContext context)
        {
            this._context = context;
        }

        public List<EnquiryStatusModel> GetAllEnquiryStatus()
        {
            return  _context.EnquiryStatus.ToList();
        }


    }
}
