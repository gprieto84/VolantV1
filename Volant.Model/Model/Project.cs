using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class Project
    {
        public int projectId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int progress { get; set; }
        public DateTime? dateCreated { get; set; }
        public DateTime? dateUpdated { get; set; }

        //References
        public int customerId { get; set; }
        public Customer customer { get; set; }

        public int statusId { get; set; }
        public ProjectStatus projectStatus { get; set; }
    }
}
