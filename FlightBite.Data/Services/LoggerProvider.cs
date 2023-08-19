using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FlightBite.Data.Services
{
    public class LoggerProvider<TContext> : ILoggerProvider where TContext : DbContext, ILoggingDbContext
    {
        private readonly DbContextOptions<TContext> _options;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoggerProvider(DbContextOptions<TContext> options, IHttpContextAccessor httpContextAccessor)
        {
            _options = options;
            _httpContextAccessor = httpContextAccessor;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new Logger<TContext>(categoryName, _options, _httpContextAccessor);
        }

        public void Dispose()
        {
            // Dispose logic if needed
        }
    }
}
