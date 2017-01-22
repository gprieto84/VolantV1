using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Model;


namespace Volant.Data.Configuration
{
    class MaterialConfiguration : EntityTypeConfiguration<Material>
    {
        public MaterialConfiguration()
        {
            ToTable("Material");
            Property(g => g.description).IsRequired().HasMaxLength(100);
        }
    }
}
