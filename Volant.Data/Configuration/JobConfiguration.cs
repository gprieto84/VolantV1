using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Model;


namespace Volant.Data.Configuration
{
    class JobConfiguration : EntityTypeConfiguration<Job>
    {
        public JobConfiguration()
        {
            ToTable("Job");
            Property(g => g.jobName).IsRequired().HasMaxLength(50);
        }
    }
}
