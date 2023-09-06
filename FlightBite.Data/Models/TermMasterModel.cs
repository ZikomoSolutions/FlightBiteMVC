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
	public class TermMasterModel : BaseEntityModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key, Column(name: "id")]
		public int Id { get; set; }

		[Required]
		[Column(name: "terms", TypeName = "nvarchar(max)")]
		public string? Terms { get; set; }

		public IList<ClientTermsModel>? ClientTermsModels { get; set; }
	}
}
