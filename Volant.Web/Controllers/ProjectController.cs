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
        // Get: Action = Create.
        public ActionResult Create ()
        {
            //Define the initial values for Project Fields.
            //Object to fill the initial values.
            var project = new ProjectFormViewModel();
            //Get all activated customers in the database.
            project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled);
            //Set the initial value for Start and End Date Project.
            project.startDate = DateTime.Now;
            project.endDate   = DateTime.Now;
            //List all project status.
            project.projectStatuses = projectService.GetProjectStatuses();
            //Return object to fill in the form.
            return View(project);
        }

        public ActionResult Edit()
        {
            //Define the initial values for Project Fields.
            //Object to fill the initial values.
            var project = new ProjectFormViewModel();
            //Get all activated customers in the database.
            project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled);
            //Set the initial value for Start and End Date Project.
            project.startDate = DateTime.Now;
            project.endDate = DateTime.Now;
            //List all project status.
            project.projectStatuses = projectService.GetProjectStatuses();
            //Return object to fill in the form.
            return View(project);
        }


        [HttpPost]
        //Handle post event to create project.
        public ActionResult Create(ProjectFormViewModel project)
        {
            #region "Vars"
            Project objProject;
            #endregion.

            if (ModelState.IsValid)
            {
                #region "Create Project"
                //Convert ViewModel to Business Object.
                objProject = Mapper.Map<ProjectFormViewModel, Project>(project);
                //Create Project.
                projectService.CreateProject(objProject);
                //Confirm the creation process.
                projectService.SaveProject();
                return RedirectToAction("Index");
                #endregion
            }
            else
            {
                #region "Send to Create Page"
                //Set values list from dropdownlist for Customers & ProjectStatuses.
                project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled); // Get All Customer Enabled.
                project.projectStatuses = projectService.GetProjectStatuses(); // Get All the project statuses configured.
                return this.View(project);
                #endregion
            }
        }
    }
}
