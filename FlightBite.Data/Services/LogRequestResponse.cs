using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FlightBite.Data.Services
{
    public class LogRequestResponse<TContext> : ILogRequestResponse where TContext : DbContext, ILoggingDbContext
    {
        private readonly DbContextOptions<TContext> _options;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LogRequestResponse(DbContextOptions<TContext> database, IHttpContextAccessor httpContextAccessor)
        {
            _options = database;
            _httpContextAccessor = httpContextAccessor;
        }

        public void RequestResponseLog(string request, string response)
        {
            // Implement request/response logging to the separate table
            using (var Database = (TContext)Activator.CreateInstance(typeof(TContext), _options))
            {
                var logEntry = new RequestResponseLogsModel
                {
                    Request = request,
                    Response = response,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    ClientIpAddress = _httpContextAccessor.HttpContext?.Connection.RemoteIpAddress?.ToString()
                };
                Database.AddRequestResponseLogEntry(logEntry);
                Database.SaveChanges();
            }
        }
    }
}
