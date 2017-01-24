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
        public ActionResult Index()
        {
            IEnumerable<ProjectViewModel> viewModelProjects;
            IEnumerable<Project> projects;

            projects = projectService.GetProjects().ToList();

            viewModelProjects = Mapper.Map<IEnumerable<Project>, IEnumerable<ProjectViewModel>>(projects);
            return View(viewModelProjects);
        }

        public ActionResult Create ()
        {
            //Define the initial values for Project Fields.
            //Object to fill the initial values.
            var project = new ProjectFormViewModel();
            //Get all activated customers in the database.
            project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled);
            //Return object to fill in the form.
            return View(project);
        }

        [HttpPost]
        public ActionResult Create(ProjectFormViewModel project)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                //project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled);
                return this.View(project);
            }
        }
    }
}