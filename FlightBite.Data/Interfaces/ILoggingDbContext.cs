using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Models;

namespace FlightBite.Data.Interfaces
{
    public interface ILoggingDbContext
    {
        void AddLogEntry(LogsMasterModel logEntry);
        void AddRequestResponseLogEntry(RequestResponseLogsModel requestResponseLogs);
    }
}
