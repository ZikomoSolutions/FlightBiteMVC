using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlightBite.Data.Models
{
    public class BaseEntityModel
    {
        [Column(name: "deleted_at")]
        public DateTime? DeletedAt { get; set; } = null;

        [Column(name: "created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Column(name: "updated_at")]
        public DateTime? UpdatedAt { get; set; } = null;
    }
}
