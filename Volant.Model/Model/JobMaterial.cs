using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class JobMaterial
    {
        public int jobMaterialId { get; set; }
        public int jobId { get; set; }
        public int materialId { get; set; }
        public decimal quantity { get; set; }
        public int estado { get; set; }
        public virtual List<JobMaterial> JobMaterials { get; set; }
    }
}