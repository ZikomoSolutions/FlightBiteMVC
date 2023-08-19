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
    public class RequestResponseLogsModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(name: "id")]
        public int? Id { get; set; }

        [Column(name: "request", TypeName = "nvarchar(MAX)")]
        public string? Request { get; set; }

        [Column(name: "response", TypeName = "nvarchar(MAX)")]
        public string? Response { get; set; }

        [Column(name: "created_at", TypeName = "DateTime")]
        public DateTime? CreatedAt { get; set; }

        [Column(name: "updated_at", TypeName = "DateTime")]
        public DateTime? UpdatedAt { get; set; }

        [Column(name: "client_ip_address", TypeName = "nvarchar(100)")]
        public string? ClientIpAddress { get; set; }
    }
}
