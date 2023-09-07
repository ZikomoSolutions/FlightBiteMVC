using FlightBite.Data.Interfaces;
using FlightBite.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlightBite.MVC.Areas.SuperAdmin.ViewModels
{
    public class EnquiryViewModel
    {
        public List<SelectListItem>? SelectedUserTypes { get; set; }
        public IEnumerable<EnquiryMasterModel>? EnquiryMasters { get; set; }

	}

}
