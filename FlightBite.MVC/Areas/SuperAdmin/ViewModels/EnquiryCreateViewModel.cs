﻿using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class EnquiryCreateViewModel
    {
        [Required]
        
        public string? CompanyName { get; set; }
        public string? ATOL { get; set; }
        public string? IATA { get; set; }
        public string? JobTitle { get; set; }
        [Required]
        [EmailAddress]
        public string? ContactEmail { get; set; }
        [Required]
        [Phone]
        public string? ContactPhone { get; set; }
        public int PlatformSelectedId { get; set; } = 1;
        public int UserTypeSelectedId { get; set; } = 1;


        public List<SelectListItem>? SelectedUserTypes { get; set; }

        public IEnumerable<EnquiryMasterModel>? EnquiryMasters { get; set; }
        public IEnumerable<EnquiryStatusModel>? EnqyiryStatus { get; set; }
        public IEnumerable<EnquiryPlatformModel>? Platforms { get; set; }
        public IEnumerable<UserTypesModel>? UserTypes { get; set; }
    }
}
