﻿// <auto-generated />
using System;
using FlightBite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightBite.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230911080638_BasicStructureChange")]
    partial class BasicStructureChange
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlightBite.Data.Models.ClientMasterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ATOL")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ATOL");

                    b.Property<string>("AccountHolder")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("account_holder");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_email");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("contact_person");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_phone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IATA");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("job_title");

                    b.Property<string>("LogoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("logo_path");

                    b.Property<string>("Other")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("other");

                    b.Property<string>("PTS")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PTS");

                    b.Property<string>("RegisterationNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("registeration_no");

                    b.Property<string>("TTA")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TTA");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserTypesModelId")
                        .HasColumnType("int");

                    b.Property<string>("VATNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("vat_number");

                    b.HasKey("Id");

                    b.HasIndex("UserTypesModelId");

                    b.ToTable("ClientMasters");
                });

            modelBuilder.Entity("FlightBite.Data.Models.ClientTermsModel", b =>
                {
                    b.Property<int>("ClientMasterModelId")
                        .HasColumnType("int");

                    b.Property<int>("TermMasterModelId")
                        .HasColumnType("int");

                    b.HasKey("ClientMasterModelId", "TermMasterModelId");

                    b.HasIndex("TermMasterModelId");

                    b.ToTable("ClientTerms");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryMasterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ATOL")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ATOL");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("company_name");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_email");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("contact_person");

                    b.Property<string>("ContactPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("contact_phone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<int>("EnquiryPlatformModelId")
                        .HasColumnType("int");

                    b.Property<int>("EnquiryStatusModelId")
                        .HasColumnType("int");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("IATA");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("job_title");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<int>("UserTypesModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnquiryPlatformModelId");

                    b.HasIndex("EnquiryStatusModelId");

                    b.HasIndex("UserTypesModelId");

                    b.ToTable("EnquiryMaster");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryNoteDetailsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<int?>("EnquiryMasterModelId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(Max)")
                        .HasColumnName("note");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.HasIndex("EnquiryMasterModelId");

                    b.ToTable("EnquiryNoteDetail");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryPlatformModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("PlatForm")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("plat_form");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("EnquityPlatform");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6465),
                            Description = "-",
                            PlatForm = "Google"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6468),
                            Description = "-",
                            PlatForm = "Brochure"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6470),
                            Description = "-",
                            PlatForm = "Other"
                        });
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryStatusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("EnquiryStatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6609),
                            Status = "In Progress"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6611),
                            Status = "Complete"
                        });
                });

            modelBuilder.Entity("FlightBite.Data.Models.LogsMasterModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("class_name");

                    b.Property<string>("ClientApiAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("client_api_address");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_at");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("file_name");

                    b.Property<int?>("LineNumber")
                        .HasColumnType("int")
                        .HasColumnName("line_number");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("message");

                    b.Property<string>("Method")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("method");

                    b.Property<string>("StackTrace")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("stack_track");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("LogsMaster");
                });

            modelBuilder.Entity("FlightBite.Data.Models.RequestLogsMasterModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ClientIpAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("client_ip_address");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_at");

                    b.Property<string>("Request")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("request");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("response");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("RequestLogsMasters");
                });

            modelBuilder.Entity("FlightBite.Data.Models.RequestResponseLogsModel", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ClientIpAddress")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("client_ip_address");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("created_at");

                    b.Property<string>("Request")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("request");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(MAX)")
                        .HasColumnName("response");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("DateTime")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("RequestResponseLogs");
                });

            modelBuilder.Entity("FlightBite.Data.Models.SupplierSourceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("SourceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("source_name");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("SupplierSourceModel");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 152, DateTimeKind.Local).AddTicks(997),
                            SourceName = "API"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 152, DateTimeKind.Local).AddTicks(999),
                            SourceName = "WEB"
                        });
                });

            modelBuilder.Entity("FlightBite.Data.Models.TermMasterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Terms")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("terms");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("TermMasters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6645),
                            Terms = "FlightBite Agreement Signed"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6647),
                            Terms = "Required Documents Added and Signed Off"
                        });
                });

            modelBuilder.Entity("FlightBite.Data.Models.UserTypesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("description");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("updated_at");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("user_type");

                    b.HasKey("Id");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6626),
                            Description = "-",
                            UserType = "Supplier"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2023, 9, 11, 13, 36, 38, 151, DateTimeKind.Local).AddTicks(6628),
                            Description = "-",
                            UserType = "Travel Agent"
                        });
                });

            modelBuilder.Entity("FlightBite.Data.Models.ClientMasterModel", b =>
                {
                    b.HasOne("FlightBite.Data.Models.UserTypesModel", "UserTypesModel")
                        .WithMany("ClientMasterModels")
                        .HasForeignKey("UserTypesModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserTypesModel");
                });

            modelBuilder.Entity("FlightBite.Data.Models.ClientTermsModel", b =>
                {
                    b.HasOne("FlightBite.Data.Models.ClientMasterModel", "ClientMasterModel")
                        .WithMany("ClientTermsModels")
                        .HasForeignKey("ClientMasterModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightBite.Data.Models.TermMasterModel", "TermMasterModel")
                        .WithMany("ClientTermsModels")
                        .HasForeignKey("TermMasterModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientMasterModel");

                    b.Navigation("TermMasterModel");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryMasterModel", b =>
                {
                    b.HasOne("FlightBite.Data.Models.EnquiryPlatformModel", "EnquiryPlatformModel")
                        .WithMany("EnquiryMasterModels")
                        .HasForeignKey("EnquiryPlatformModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightBite.Data.Models.EnquiryStatusModel", "EnquiryStatusModel")
                        .WithMany("EnquiryMasterModels")
                        .HasForeignKey("EnquiryStatusModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightBite.Data.Models.UserTypesModel", "UserTypesModel")
                        .WithMany("EnquiryMasterModels")
                        .HasForeignKey("UserTypesModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EnquiryPlatformModel");

                    b.Navigation("EnquiryStatusModel");

                    b.Navigation("UserTypesModel");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryNoteDetailsModel", b =>
                {
                    b.HasOne("FlightBite.Data.Models.EnquiryMasterModel", "EnquiryMasterModel")
                        .WithMany("EnquiryNoteDetailsModel")
                        .HasForeignKey("EnquiryMasterModelId");

                    b.Navigation("EnquiryMasterModel");
                });

            modelBuilder.Entity("FlightBite.Data.Models.ClientMasterModel", b =>
                {
                    b.Navigation("ClientTermsModels");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryMasterModel", b =>
                {
                    b.Navigation("EnquiryNoteDetailsModel");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryPlatformModel", b =>
                {
                    b.Navigation("EnquiryMasterModels");
                });

            modelBuilder.Entity("FlightBite.Data.Models.EnquiryStatusModel", b =>
                {
                    b.Navigation("EnquiryMasterModels");
                });

            modelBuilder.Entity("FlightBite.Data.Models.TermMasterModel", b =>
                {
                    b.Navigation("ClientTermsModels");
                });

            modelBuilder.Entity("FlightBite.Data.Models.UserTypesModel", b =>
                {
                    b.Navigation("ClientMasterModels");

                    b.Navigation("EnquiryMasterModels");
                });
#pragma warning restore 612, 618
        }
    }
}
