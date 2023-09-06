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
	public class SupplierSourceModel : BaseEntityModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key, Column(name: "id")]
		public int Id { get; set; }

		[Required]
		[Column(name: "source_name", TypeName = "nvarchar(50)")]
		public string? SourceName { get; set; }
	}
}
