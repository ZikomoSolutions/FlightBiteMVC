using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlightBite.Data.Models
{
	public class ClientMasterModel : BaseEntityModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key, Column(name: "id")]
		public int Id { get; set; }

		[Required]
		[Column(name: "company_name", TypeName = "nvarchar(150)")]
		public string? CompanyName { get; set; }

		[Required]
		[Column(name: "contact_person", TypeName = "nvarchar(150)")]
		public string? ContactPerson { get; set; }

		[Required]
		[Column(name:"vat_number", TypeName ="nvarchar(50)")]
		public string? VATNumber { get; set; }

		[Required]
		[Column(name:"registeration_no", TypeName ="nvarchar(50)")]
		public string? RegisterationNo { get; set; }

		[Required]
		[Column(name: "account_holder", TypeName = "nvarchar(150)")]
		public string? AccountHolder { get; set; }

		[Required]
		[Column(name: "job_title", TypeName = "nvarchar(50)")]
		public string? JobTitle { get; set; }

		[Required]
		[Column(name: "contact_email", TypeName = "nvarchar(50)")]
		public string? ContactEmail { get; set; }

		[Required]
		[Column(name: "ATOL", TypeName = "nvarchar(50)")]
		public string? ATOL { get; set; }

		[Required]
		[Column(name: "IATA", TypeName = "nvarchar(50)")]
		public string? IATA { get; set; }

		[Required]
		[Column(name: "PTS", TypeName = "nvarchar(50)")]
		public string? PTS { get; set; }

		[Required]
		[Column(name: "TTA", TypeName = "nvarchar(50)")]
		public string? TTA { get; set; }

		[Required]
		[Column(name: "other", TypeName = "nvarchar(max)")]
		public string? Other { get; set; }

		[Required]
		[Column(name: "contact_phone", TypeName = "nvarchar(50)")]
		public string? ContactPhone { get; set; }

		[Required]
		[Column(name: "logo_path", TypeName = "nvarchar(max)")]
		public string? LogoPath { get; set; }

		[ForeignKey("user_type_id")]
		public int UserTypesModelId { get; set; }
		public UserTypesModel? UserTypesModel { get; set; }

		public IList<ClientTermsModel>?	ClientTermsModels { get; set; }


	}
}
