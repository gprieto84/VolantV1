using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Volant.Data.Infrastructure;
using Volant.Model;
using System.Data.SqlClient;
using System.Data;

namespace Volant.Data.Repositories
{
    public class SimulationRepository : RepositoryBase<Simulation>, ISimulationRepository
    {
        public SimulationRepository(IDbFactory dbFactory)
            : base(dbFactory) { }



        public IEnumerable<Simulation> StockSimulation(int? projectId)
        {
            return DbContext.Database.SqlQuery<Simulation>(@"[dbo].[StockSimulation] @projectId", new SqlParameter("projectId", SqlDbType.Int) { Value = projectId }); 
        }

    }

    public interface ISimulationRepository : IRepository<Simulation>
    {
        IEnumerable<Simulation> StockSimulation(int? projectId);
    }
}
