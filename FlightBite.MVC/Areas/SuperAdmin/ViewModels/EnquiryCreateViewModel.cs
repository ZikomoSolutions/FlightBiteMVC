using System.ComponentModel.DataAnnotations;
using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
	public class EnquiryCreateViewModel 
    {
		[Required(ErrorMessage = "The company name is required ")]
		public string? CompanyName { get; set; }
		public string? ATOL { get; set; }
		public string? IATA { get; set; }
		public string? JobTitle { get; set; }
		[Required(ErrorMessage = "The email is required")]
		[EmailAddress]
		public string? ContactEmail { get; set; }
		[Required(ErrorMessage = "The phone number is required")]
		[Phone]
		public string? ContactPhone { get; set; }
		public int PlatformSelectedId { get; set; } = 1;
		public int UserTypeSelectedId { get; set; } = 1;

		public IEnumerable<EnquiryPlatformModel>? Platforms { get; set; }

		public IEnumerable<UserTypesModel>? UserTypes { get; set; }

	}
}
