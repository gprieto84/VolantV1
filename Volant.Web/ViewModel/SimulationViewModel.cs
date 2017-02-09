using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Volant.Web.ViewModel
{
    public class SimulationViewModel
    {
        public int materialId { get; set; }

        public int jobId { get; set; }

        public decimal quantity { get; set; }

        public int priority { get; set; }

        public int jobIdAffected { get; set; }

        public string status { get; set; }

    }
}