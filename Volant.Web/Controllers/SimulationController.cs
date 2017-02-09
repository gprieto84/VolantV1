using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Volant.Model;
using Volant.Service;
using Volant.Web.ViewModel;

namespace Volant.Web.Controllers
{
    public class SimulationController : Controller
    {


        private readonly ISimulationService simulationService;

        public SimulationController(ISimulationService simulationService)
        {
            this.simulationService = simulationService;
        }
        // GET: Simulation
        public ActionResult Index(int projectId)
        {

            IEnumerable<SimulationViewModel> viewModelSimulations;
            IEnumerable<Simulation> simulations;

            simulations = simulationService.StockSimulation(projectId);
            viewModelSimulations = Mapper.Map<IEnumerable<Simulation>, IEnumerable<SimulationViewModel>>(simulations);
            return View(viewModelSimulations);
        }

        
    }
}