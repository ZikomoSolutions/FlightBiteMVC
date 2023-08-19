using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBite.Data.Models
{
    public class EnquiryNoteDetailsModel : BaseEntityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int Id { get; set; }

        [Column(name:"enquiry_id")]
        public int EnquiryId { get; set; }

        [Column(name:"note", TypeName ="nvarchar(Max)")]
        public string? Note { get; set; }
    }
}
