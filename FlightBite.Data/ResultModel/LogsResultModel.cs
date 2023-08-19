using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.ResultModel
{
    public class LogsResultModel : BasePaginationModel
    {
        [JsonPropertyOrder(5)]
        public List<LogsMasterModel> Data { get; set; }
    }
}
