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

        public DbSet<ClientMasterModel> ClientMasters { get; set; }
        public DbSet<TermMasterModel> TermMasters { get; set; }
        public DbSet<ClientTermsModel> ClientTerms { get; set; }
        public DbSet<ClientNoteDetailsModel> ClientNoteDetails { get; set; }
        public DbSet<SupplierSourceModel> SupplierSources { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientTermsModel>().HasKey(c => new { c.ClientMasterModelId, c.TermMasterModelId });
            modelBuilder.Entity<ClientTermsModel>().HasOne(ct => ct.ClientMasterModel).WithMany(m => m.ClientTermsModels).HasForeignKey(c => c.ClientMasterModelId);
            modelBuilder.Entity<ClientTermsModel>().HasOne(ct => ct.TermMasterModel).WithMany(m => m.ClientTermsModels).HasForeignKey(c=>c.TermMasterModelId);

            modelBuilder.Entity<EnquiryPlatformModel>().HasData
            (
                new EnquiryPlatformModel
                {
                    Id = 1,
                    PlatForm = "Google",
                    Description = "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new EnquiryPlatformModel
                {
                    Id = 2,
                    PlatForm = "Brochure",
                    Description = "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new EnquiryPlatformModel
                {
                    Id = 3,
                    PlatForm = "Other",
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
                    UserType = "Supplier",
                    Description= "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new UserTypesModel
                {
                    Id = 2,
                    UserType = "Travel Agent",
                    Description= "-",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                }
            );

            modelBuilder.Entity<TermMasterModel>().HasData
            (
                new TermMasterModel
                {
                    Id = 1,
                    Terms = "FlightBite Agreement Signed",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new TermMasterModel
                {
                    Id = 2,
                    Terms = "Required Documents Added and Signed Off",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                }
            );

            modelBuilder.Entity<SupplierSourceModel>().HasData
            (
                new SupplierSourceModel
                {
                    Id = 1,
                    SourceName = "NotInUsed",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new SupplierSourceModel
                {
                    Id = 2,
                    SourceName = "API",
                    CreatedAt  = DateTime.Now,
                    UpdatedAt = null,
                    DeletedAt = null,
                },
                new SupplierSourceModel
                {
                    Id = 3,
                    SourceName = "WEB",
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
