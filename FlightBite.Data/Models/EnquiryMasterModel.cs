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
        public string? ContactPerson { get; set; } = null;

        [Required]
        [Column(name: "ATOL", TypeName = "nvarchar(50)")]
        public string? ATOL { get; set; } = null;

        [Required]
        [Column(name: "IATA", TypeName = "nvarchar(50)")]
        public string? IATA { get; set; } = null;

        [Required]
        [Column(name: "job_title", TypeName = "nvarchar(50)")]
        public string? JobTitle { get; set; } = null;

        [Required]
        [Column(name:"contact_email", TypeName = "nvarchar(50)")]
        public string? ContactEmail { get; set; }

        [Required]
        [Column(name:"contact_phone", TypeName ="nvarchar(50)")]
        public string? ContactPhone { get; set; }

        public int EnquiryPlatformModelId { get; set; }
        public EnquiryPlatformModel? EnquiryPlatformModel { get; set; }
        public int EnquiryStatusModelId { get; set; }
        public EnquiryStatusModel? EnquiryStatusModel { get; set; }
        public int UserTypesModelId { get; set; }
        public UserTypesModel? UserTypesModel { get; set; }

        public ICollection<EnquiryNoteDetailsModel>? EnquiryNoteDetailsModel { get; set; }

    }
}
