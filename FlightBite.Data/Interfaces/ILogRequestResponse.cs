using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBite.Data.Interfaces
{
    public interface ILogRequestResponse
    {
        void RequestResponseLog(string request, string response);
    }
}
