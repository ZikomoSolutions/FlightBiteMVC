using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FlightBite.Data
{
    public class DatabaseContext : DbContext, ILoggingDbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EnquiryMasterModel> EnquiryMaster { get; set;}
        public DbSet<EnquiryNoteDetailsModel> EnquiryNoteDetail { get; set;}
        public DbSet<EnquiryStatusModel> EnquiryStatus { get; set;}
        public DbSet<EnquiryPlatformModel> EnquityPlatform { get; set;}
        public DbSet<UserTypesModel> UserType { get; set;}
        public DbSet<LogsMasterModel> LogsMaster { get; set; }
        public DbSet<RequestResponseLogsModel> RequestResponseLogs { get; set; }
        public DbSet<RequestLogsMasterModel> RequestLogsMasters { get; set; }  
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnquiryPlatformModel>().HasData
            (
                new EnquiryPlatformModel
                {
                    Id = 1,
                    Name = "Google",
                    Description = "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new EnquiryPlatformModel
                {
                    Id = 2,
                    Name = "Brochure",
                    Description = "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new EnquiryPlatformModel
                {
                    Id = 3,
                    Name = "Other",
                    Description = "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                }
            );

            modelBuilder.Entity<EnquiryStatusModel>().HasData
            (
                new EnquiryStatusModel
                {
                    Id = 1,
                    Status = "In Progress",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new EnquiryStatusModel
                {
                    Id = 2,
                    Status = "Complete",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                }
            );

            modelBuilder.Entity<UserTypesModel>().HasData
            (
                new UserTypesModel
                {
                    Id = 1,
                    Type = "Flight Provider / Consolidator",
                    Description= "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new UserTypesModel
                {
                    Id = 2,
                    Type = "Travel Agent",
                    Description= "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                }
            );
        }

        public void AddLogEntry(LogsMasterModel logEntry)
        {
            LogsMaster.Add(logEntry);
        }
        public void AddRequestResponseLogEntry(RequestResponseLogsModel requestResponseLogs)
        {
            RequestResponseLogs.Add(requestResponseLogs);
        }
    }
}
