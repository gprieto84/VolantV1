using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;

namespace Volant.Data.Repositories
{
    public class JobMaterialRepository : RepositoryBase<JobMaterial>, IJobMaterialRepository
    {
        public JobMaterialRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<JobMaterial> GetJobMaterialsByJob(int? jobId)
        {

           return DbContext.JobMaterials
                .Include(c => c.material)
                .Include(c => c.job)
                .Where(c => c.jobId == jobId)
                .ToList();         
        }
    }

    public interface IJobMaterialRepository : IRepository<JobMaterial>
    {
        IEnumerable<JobMaterial> GetJobMaterialsByJob(int? jobId);

    }
}
