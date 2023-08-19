using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class EnquiryCreateViewModel
    {
        public string? CompanyName { get; set; }
        public string? ContactPerson { get; set; }
        public string? ATOL { get; set; }
        public string? IATA { get; set; }
        public string? JobTitle { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public IEnumerable<EnquiryPlatformModel>? PlatformMaster { get; set; }
        public int UserTypeId { get; set; }
    }
}
