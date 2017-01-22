using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Model;


namespace Volant.Data.Configuration
{
    class JobStatusConfiguration : EntityTypeConfiguration<JobStatus>
    {
        public JobStatusConfiguration()
        {
            ToTable("JobStatus");
            Property(g => g.name).IsRequired().HasMaxLength(50);
        }
    }
}
