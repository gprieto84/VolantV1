using Volant.Data.Infrastructure;
using Volant.Data.Repositories;
using Volant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Volant.Service
{
    public interface ISimulationService
    {
        IEnumerable<Simulation> StockSimulation(int? projectId);

    }

    public class SimulationService : ISimulationService
    {
        private readonly ISimulationRepository simulationRepository;
        private readonly IUnitOfWork unitOfWork;

        public SimulationService(ISimulationRepository simulationRepository, IUnitOfWork unitOfWork)
        {
            this.simulationRepository = simulationRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IJobService Members

        public IEnumerable<Simulation> StockSimulation(int? projectId)
        {
            var simulations = simulationRepository.StockSimulation(projectId);
            return simulations;
        }

        #endregion

    }
}
