using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace FlightBite.Data.Models
{
    public class EnquiryMasterModel : BaseEntityModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int Id { get; set; }

        [Required]
        [Column(name: "company_name", TypeName ="nvarchar(150)")]
        public string? CompanyName { get; set; }

        [Required]
        [Column(name: "contact_person", TypeName ="nvarchar(150)")]
        public string? ContactPerson { get; set; }

        [Required]
        [Column(name: "ATOL", TypeName = "nvarchar(50)")]
        public string? ATOL { get; set; }

        [Required]
        [Column(name: "IATA", TypeName = "nvarchar(50)")]
        public string? IATA { get; set; }

        [Required]    
        [Column(name:"job_title", TypeName = "nvarchar(50)")]
        public string? JobTitle { get; set; }

        [Required]
        [Column(name:"contact_email", TypeName = "nvarchar(50)")]
        public string? ContactEmail { get; set; }

        [Required]
        [Column(name:"contact_phone", TypeName ="nvarchar(50)")]
        public string? ContactPhone { get; set;}

        [ForeignKey("plat_form_id")]
        public int EnquiryPlatformModelId { get; set; }
        public EnquiryPlatformModel? EnquiryPlatformModel { get; set; }
        [ForeignKey("status_id")]
        public int EnquiryStatusModelId { get; set; }
        public EnquiryStatusModel? EnquiryStatusModel { get; set; }
        [ForeignKey("user_type_id")]
        public int UserTypesModelId { get; set; }
        public UserTypesModel? UserTypesModel { get; set; }


        public ICollection<EnquiryNoteDetailsModel>? EnquiryNoteDetailsModel { get; set; }

        [NotMapped]
        public string? EnquiryNote { get; set; }
    }
}
