using Volant.Data.Configuration;
using Volant.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace Volant.Data
{
    public class VolantEntities : DbContext
    {
        public VolantEntities() : base("VolantEntities") { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProjectStatus> ProjectStatuses { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobStatus> JobStatuses { get; set; }
        public DbSet<JobMaterial> JobMaterials { get; set; }
        public DbSet<Material> MaterialStatuses { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProjectConfiguration());
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new ProjectStatusConfiguration());
            modelBuilder.Configurations.Add(new JobTypeConfiguration());
            modelBuilder.Configurations.Add(new JobStatusConfiguration());
            modelBuilder.Configurations.Add(new JobConfiguration());
            modelBuilder.Configurations.Add(new MaterialConfiguration());
            modelBuilder.Configurations.Add(new JobMaterialConfiguration());

        }
    }
}
