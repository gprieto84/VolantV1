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
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        // GET: Home
        public ActionResult Index(string customer = null)
        {
            IEnumerable<ProjectViewModel> viewModelProjects;
            //IEnumerable<Customer> customers;
            IEnumerable<Project> projects;

            projects = projectService.GetProjects().ToList();
            //customers = customerService.GetCustomers(customer).ToList();

            viewModelProjects = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projects);
            return View(viewModelProjects);
        }
    }
}