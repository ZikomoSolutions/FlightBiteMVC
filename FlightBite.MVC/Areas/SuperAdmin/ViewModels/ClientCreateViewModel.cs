using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

		public string? VATNumber { get; set; } = "-";

        public string? RegisterationNo { get; set; } = "-";

        public string? AccountHolder { get; set; } = "-";

		public string? JobTitle { get; set; } = "-";

        [Required(ErrorMessage = "The email is required")]
		[EmailAddress]
		public string? ContactEmail { get; set; }

		public string? ATOL { get; set; } = "-";

		public string? IATA { get; set; } = "-";

        public string? PTS { get; set; } = "-";

		public string? TTA { get; set; } = "-";

        public string? Other { get; set; } = "-";

		[Required(ErrorMessage = "The phone number is required")]
		[Phone]
		public string? ContactPhone { get; set; } = "0";

		public IFormFile? Logo { get; set; }

		public int UserTypeSelectedId { get; set; } = 1;

        public IEnumerable<UserTypesModel>? UserTypes { get; set; }

		public int SupplierSourceModelId { get; set; } = 1;

		public IEnumerable<SupplierSourceModel>? SupplierSourceModels { get; set; }

		public int TermMasterModelId { get; set; }

		public List<CheckBoxItem>? AvailableTerms { get; set; }

		public List<string>? SelectedTerms { get; set; }




    }
}
