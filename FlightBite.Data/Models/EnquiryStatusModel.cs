using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBite.Data.Models
{
    public class EnquiryStatusModel : BaseEntityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int Id { get; set; }

        [Column(name: "status", TypeName = "nvarchar(50)")]
        public string? Status { get; set; }

        public ICollection<EnquiryMasterModel>? EnquiryMasterModels { get; set; }
    }
}
