using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;

namespace Volant.Data.Repositories
{
    public class JobStatusRepository : RepositoryBase<JobStatus>, IJobStatusRepository
    {
        public JobStatusRepository(IDbFactory dbFactory)
            : base(dbFactory) { }
    }

    public interface IJobStatusRepository : IRepository<JobStatus>
    {

    }
}
