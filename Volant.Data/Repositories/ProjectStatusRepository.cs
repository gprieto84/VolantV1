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
    public class ProjectStatusRepository : RepositoryBase<ProjectStatus>, IProjectStatusRepository
    {
        public ProjectStatusRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public override IEnumerable<ProjectStatus> GetAll()
        {
            return DbContext.ProjectStatuses.ToList();
        }
    }

    public interface IProjectStatusRepository : IRepository<ProjectStatus>
    {

    }
}
