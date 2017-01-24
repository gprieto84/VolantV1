using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Volant.Model;

namespace Volant.Web.ViewModel
{
    public class ProjectViewModel
    {
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }


        [DisplayFormat(DataFormatString = "{0:dd/mmm/yyyy}")]
        public DateTime endDate { get; set; }
        public int progress { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string projectStatusName { get; set; }
    }
}