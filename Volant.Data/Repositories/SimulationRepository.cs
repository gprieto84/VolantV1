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
    public class SimulationRepository : RepositoryBase<Simulation>, ISimulationRepository
    {
        public SimulationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }



        public IEnumerable<Simulation> Simulate(int? projectId)
        {
            return ; 
        }

    }

    public interface ISimulationRepository : IRepository<Simulation>
    {
        IEnumerable<Simulation> Simulate(int? projectId);
    }
}
