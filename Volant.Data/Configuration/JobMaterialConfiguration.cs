using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Model;

namespace Volant.Data.Configuration
{
    class JobMaterialConfiguration : EntityTypeConfiguration<JobMaterial>
    {
        public JobMaterialConfiguration()
        {
            ToTable("JobMaterial");
            Property(g => g.jobId).IsRequired();
        }
    }

}