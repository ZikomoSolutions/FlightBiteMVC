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
    public class LogsMasterModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int? Id { get; set; }

        [Column(name: "message", TypeName = "nvarchar(MAX)")]
        public string? Message { get; set; }

        [Column(name: "stack_track", TypeName = "nvarchar(MAX)")]
        public string? StackTrace { get; set; }

        [Column(name: "file_name", TypeName = "nvarchar(100)")]
        public string? FileName { get; set; }

        [Column(name: "class_name", TypeName = "nvarchar(100)")]
        public string? ClassName { get; set; }

        [Column(name: "method", TypeName = "nvarchar(100)")]
        public string? Method { get; set; }

        [Column(name: "line_number")]
        public int? LineNumber { get; set; }

        [Column(name: "created_at", TypeName = "DateTime")]
        public DateTime? CreatedAt { get; set; }

        [Column(name: "updated_at", TypeName = "DateTime")]
        public DateTime? UpdatedAt { get; set; }

        [Column(name: "client_api_address", TypeName = "nvarchar(100)")]
        public string? ClientApiAddress { get; set; }
    }
}
