using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volant.Web.ViewModel
{
    public class ProjectFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int progress { get; set; }
        public int customerId { get; set; }
        public int projectStatusId { get; set; }
    }
}