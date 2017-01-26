using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Volant.Model;
using System.ComponentModel.DataAnnotations;

namespace Volant.Web.ViewModel
{
   

    public class ProjectFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string description { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime startDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "End Date")]
        public DateTime endDate { get; set; }
        [Range(1, 100)]
        [Display(Name = "Progress")]
        public int progress { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public int customerId { get; set; }
        [Required]
        [Display(Name = "Status")]
        public int projectStatusId { get; set; }
        public IEnumerable<Customer> customers { get; set;  }
        public IEnumerable<ProjectStatus> projectStatuses { get; set; }
    }
}