using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Volant.Model;
using Volant.Service;
using Volant.Web.ViewModel;


namespace Volant.Web.Controllers
{
    public class JobMaterialController : Controller
    {

        private readonly IJobMaterialService jobMaterialService;

        public JobMaterialController(IJobMaterialService jobMaterialService)
        {
            this.jobMaterialService = jobMaterialService;
        }
        // GET: JobMaterial
        public ActionResult IndexByJob(int? id)
        {
            IEnumerable<JobMaterialViewModel> viewModelJobMaterials;
            IEnumerable<JobMaterial> jobMaterials;
           
            jobMaterials = jobMaterialService.GetJobMaterialsByJob(id).ToList();
            

            viewModelJobMaterials = Mapper.Map<IEnumerable<JobMaterial>, IEnumerable<JobMaterialViewModel>>(jobMaterials);
            return View(viewModelJobMaterials);
        }

        
    }
}