using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
	public class ClientCreateViewModel
	{
		[Required(ErrorMessage = "The company name is required ")]
		public string? CompanyName { get; set; }

		public string? ContactPerson { get; set; } = "-";

		[Required]
		[Column(name: "vat_number", TypeName = "nvarchar(50)")]
		public string? VATNumber { get; set; }

		[Required]
		[Column(name: "registeration_no", TypeName = "nvarchar(50)")]
		public string? RegisterationNo { get; set; }

		[Required]
		[Column(name: "account_holder", TypeName = "nvarchar(150)")]
		public string? AccountHolder { get; set; }

		[Required]
		[Column(name: "job_title", TypeName = "nvarchar(50)")]
		public string? JobTitle { get; set; }

		[Required(ErrorMessage = "The email is required")]
		[EmailAddress]
		public string? ContactEmail { get; set; }

		[Required]
		[Column(name: "ATOL", TypeName = "nvarchar(50)")]
		public string? ATOL { get; set; }

		[Required]
		[Column(name: "IATA", TypeName = "nvarchar(50)")]
		public string? IATA { get; set; }

		public string? PTS { get; set; }

		public string? TTA { get; set; }

		public string? Other { get; set; }

		public string? ContactPhone { get; set; }

		public string? LogoPath { get; set; }

		public int UserTypesModelId { get; set; }
		public UserTypesModel? UserTypesModel { get; set; }
	}
}
