
using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
	public class EnquiryInfoViewModel 
	{
		public int Id { get; set; } //Enquiry Id
		public string? CompanyName { get; set; }
		public string? ContactPerson { get; set; } = "-";
		public string? ATOL { get; set; }
		public string? IATA { get; set; }
		public string? JobTitle { get; set; }
		public string? ContactEmail { get; set; }
		public string? ContactPhone { get; set; }
		public string? PlatForm { get; set;}

		public int EnquiryStatusModelId { get; set; }
		public ICollection<EnquiryStatusModel>? EnquiryStatus { get; set; }
	}
}
