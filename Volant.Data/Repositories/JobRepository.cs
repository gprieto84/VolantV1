using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;

namespace Volant.Data.Repositories
{
    public class JobRepository : RepositoryBase<Job>, IJobRepository
    {
        public JobRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public IEnumerable<Job> GetJobsByProject(int? projectId)
        {
            return DbContext.Jobs
                     .Include(c => c.jobStatus)
                     .Include(c => c.jobType)
                     .Where(c => c.projectId == projectId)
                     .ToList();
        }

    }

    public interface IJobRepository : IRepository<Job>
    {
        IEnumerable<Job> GetJobsByProject(int? projectId);
    }
}
