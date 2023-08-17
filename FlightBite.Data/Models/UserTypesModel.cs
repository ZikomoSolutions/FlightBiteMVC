using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBite.Data.Models
{
    public class UserTypesModel : BaseEntityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int Id { get; set; }

        [Required]
        [Column(name:"type", TypeName ="nvarchar(50)")]
        public string? Type { get; set; }
        
        [Column(name:"description", TypeName ="nvarchar(255)")]
        public string? Description { get; set; }
    }
}
