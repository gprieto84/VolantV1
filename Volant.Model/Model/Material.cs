using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volant.Model
{
    public class Material
    {
        public int materialId { get; set; }
        public string description { get; set; }
        public int grade { get; set; }
        public string sc { get; set; }
        public string endc { get; set; }
        public int? rat  { get; set; }
        public double? size1 { get; set; }
        public double? size2 { get; set; }
        public int? sch1 { get; set; }
        public int? sch2 { get; set; }
        public double? wgt { get; set; }
        
    }
}
