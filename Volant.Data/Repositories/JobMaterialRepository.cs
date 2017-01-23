using System;
using System.Collections.Generic;
using System.Linq;
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
    }

    public interface IJobMaterialRepository : IRepository<JobMaterial>
    {

    }
}

