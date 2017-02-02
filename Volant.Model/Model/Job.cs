using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class Job
    {
        public int jobId { get; set; }
        public string jobName { get; set; }

        public string jobIdentifier { get; set; }

        public int priority { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public DateTime? dateCreated { get; set; }
        public DateTime? dateUpdated { get; set; }

        //References
        public int jobTypeId { get; set; }
       public JobType jobType { get; set; }


        public int projectId { get; set; }
        public Project project { get; set; }

        public int jobStatusId { get; set; }
        public JobStatus jobStatus { get; set; }

        public List<JobMaterial> JobMaterials { get; set; }

        public Job()
        {
            dateCreated = DateTime.Now;
        }
    }
}
