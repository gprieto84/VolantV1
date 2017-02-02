using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class Simulation
    {
        public int materialId { get; set; }

        public int jobId { get; set; }

        public decimal quantity { get; set; }

        public int priority { get; set; }

        public int jobIdAffected { get; set; }

        public string status { get; set; }
    }
}
