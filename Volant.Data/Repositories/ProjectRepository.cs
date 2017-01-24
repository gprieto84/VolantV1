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
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(IDbFactory dbFactory)
            : base(dbFactory) { }

        public override IEnumerable<Project> GetAll()
        {
            return DbContext.Projects
                     .Include(c => c.customer)
                     .Include(c => c.projectStatus)
                     .ToList();
        }
    }

    public interface IProjectRepository : IRepository<Project>
    {

    }
}
