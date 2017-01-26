using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Volant.Web.Controllers
{
    public class JobMaterialController : Controller
    {
        // GET: JobMaterial
        public ActionResult IndexByJob(int id)
        {
            return View();
        }
    }
}