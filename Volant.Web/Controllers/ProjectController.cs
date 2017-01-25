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
            //Set the initial value for Start and End Date Project.
            project.startDate = DateTime.Now;
            project.endDate   = DateTime.Now;
            //List all project status.
            project.projectStatuses = projectService.GetProjectStatuses();
            //Return object to fill in the form.
            return View(project);
        }

        [HttpPost]
        public ActionResult Create(ProjectFormViewModel project)
        {
            #region "Vars"
            Project objProject;
            #endregion.
            if (ModelState.IsValid)
            {

                //Convert ViewModel to Business Object.
                //objProject = (Project) Mapper.Map(project,typeof(ProjectFormViewModel), typeof(Project));
                //objProject = Mapper.Map<ProjectFormViewModel, Project>(project)
                //    .ForMember(c => c.Sectors, option => option.Ignore())
                //    .ForMember(c => c.Cities, option => option.Ignore());
            
                

                //Create Project.
                //projectService.CreateProject(objProject);
                //Confirm the creation process.
                //projectService.SaveProject();

                return RedirectToAction("Index");
            }
            else
            {
                project.customers = projectService.GetAllCustomerByStatus(CustomerStatusId.enabled);
                project.projectStatuses = projectService.GetProjectStatuses();
                return this.View(project);
            }
        }
    }
}
