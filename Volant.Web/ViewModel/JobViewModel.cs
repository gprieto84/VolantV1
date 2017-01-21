using System;
using System.Collections.Generic;
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
        public DateTime endDate { get; set; }
        public int priority { get; set; }

        public int jobTypeId { get; set; }
        public int projectId { get; set; }
        public int jobStatusId { get; set; }

    }
}