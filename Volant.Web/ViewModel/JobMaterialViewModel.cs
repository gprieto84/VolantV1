using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volant.Web.ViewModel
{
    public class JobMaterialViewModel
    {
        public int jobMaterialId { get; set; }
        public int jobId { get; set; }
        public int materialId { get; set; }
        public decimal quantity { get; set; }
        public string materialName { get; set; }
        public string jobName { get; set; }

    }
}