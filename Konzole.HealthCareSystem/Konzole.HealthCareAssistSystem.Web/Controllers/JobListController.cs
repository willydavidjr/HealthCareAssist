using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using Konzole.HealthCareAssistSystem.Entities;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;

namespace Konzole.HealthCareAssistSystem.Web.Controllers
{
    public class JobListController : Controller
    {
        private IJobListProvider _JobListProvider = null;

        // GET: JobList
        public ActionResult Index()
        {
            JobListModel mod = new JobListModel();
            List<JobList> lstJobList = new List<JobList>();
            lstJobList = _JobListProvider.GetList().ToList();
            mod.JobList = lstJobList;

            return View(mod);
        }

        public JobListController(IJobListProvider JobListProvider)
        {
            this._JobListProvider = JobListProvider;
        }

        public ActionResult JobListDetails(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobList jobList = _JobListProvider.GetByUserId(id);
            if (jobList == null)
            {
                return HttpNotFound();
            }
            return View(jobList);
        }



    }
}