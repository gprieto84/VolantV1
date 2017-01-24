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
    public class JobController : Controller
    {

        private readonly IJobService jobService;

        public JobController(IJobService jobService)
        {
            this.jobService = jobService;
        }



        // GET: Order
        public ActionResult Index(int? projectId)
        {
            IEnumerable<JobViewModel> viewModelJobs;
            IEnumerable<Job> jobs;
            if (projectId == null)
                jobs = jobService.GetJobs().ToList();
            else
                jobs = jobService.GetJobsByProject(projectId).ToList();

            viewModelJobs = Mapper.Map<IEnumerable<Job>, IEnumerable<JobViewModel>>(jobs);
            return View(viewModelJobs);
        }
    }
}