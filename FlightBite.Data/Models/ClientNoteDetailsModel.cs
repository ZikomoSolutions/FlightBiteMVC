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
	public class ClientNoteDetailsModel : BaseEntityModel
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key, Column(name: "id")]
		public int Id { get; set; }

		[Column(name: "note", TypeName = "nvarchar(Max)")]
		public string? Note { get; set; }

		//Navigation
		[ForeignKey("client_id")]
		public int? ClientMasterModelId { get; set; }

		public ClientMasterModel? ClientMasterModel { get; set; }
	}
}
