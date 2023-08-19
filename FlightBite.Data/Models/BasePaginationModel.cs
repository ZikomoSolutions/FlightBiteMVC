using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FlightBite.Data.Models
{
    public class BasePaginationModel
    {
        [JsonPropertyOrder(1)]
        public int PageNumber { get; set; }

        [JsonPropertyOrder(2)]
        public int PageSize { get; set; }

        [JsonPropertyOrder(3)]
        public int TotalPages { get; set; }

        [JsonPropertyOrder(4)]
        public int Results { get; set; }
    }
}
