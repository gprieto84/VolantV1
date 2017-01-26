using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volant.Web.ViewModel
{
    public class JobViewModel
    {
        public int jobId { get; set; }
        public string jobName { get; set; }
        public string jobIdentifier { get; set; }
        public DateTime startDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/mmm/yyyy}")]
        public DateTime endDate { get; set; }
        public int priority { get; set; }

        public string jobTypeName { get; set; }
        public int projectId { get; set; }
        public string projectName { get; set; }
        public string jobStatusName { get; set; }

    }
}