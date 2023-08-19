using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FlightBite.Data.Services
{
    public class Logger<TContext> : ILogger where TContext : DbContext, ILoggingDbContext
    {
        private readonly string categoryName;
        private readonly DbContextOptions<TContext> _options;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public Logger(string categoryName,
                                DbContextOptions<TContext> options,
                                IHttpContextAccessor httpContextAccessor)
        {
            this.categoryName = categoryName;
            _options = options;
            _httpContextAccessor = httpContextAccessor;
        }

        public IDisposable? BeginScope<TState>(TState state)
        {
            return null;
        }


        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            // Only log if the logLevel is Error
            if (logLevel != LogLevel.Error)
                return;

            using (var database = Activator.CreateInstance(typeof(TContext), _options) as TContext)
            {
                var logEntry = new LogsMasterModel
                {
                    Message = formatter(state, exception),
                    StackTrace = exception?.StackTrace + exception?.InnerException,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    ClientApiAddress = _httpContextAccessor.HttpContext?.Connection.RemoteIpAddress?.ToString()
                };

                // Extract additional details from the stack trace if available
                if (exception != null)
                {
                    var stackTrace = new StackTrace(exception, true);
                    StackFrame? frame = null!;

                    for (int i = 0; i < stackTrace?.FrameCount; i++)
                    {
                        frame = stackTrace?.GetFrame(i);
                        if (!string.IsNullOrEmpty(frame?.GetFileName()))
                        {
                            break;
                        }
                    }
                    if (frame != null)
                    {
                        var method = frame.GetMethod();

                        logEntry.FileName = frame?.GetFileName();
                        logEntry.ClassName = method?.ReflectedType?.FullName;
                        logEntry.Method = method?.Name;
                        logEntry.LineNumber = frame?.GetFileLineNumber();
                    }
                }

                database.AddLogEntry(logEntry);
                database.SaveChanges();
            }
        }
    }
}
