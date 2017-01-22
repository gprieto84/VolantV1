using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class JobStatus
    {
        public int jobStatusId { get; set; }
        public string name { get; set; }

        public virtual List<Job> Jobs { get; set; }


    }
}
