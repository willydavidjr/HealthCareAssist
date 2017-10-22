using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;


namespace Konzole.HealthCareAssistSystem.Providers
{
    public class JobListProvider : BaseProvider, IJobListProvider
    {
        public JobListProvider(ApplicationDbContext context, ILoggingProvider loggingProvider)
        {
            this._db = context;
            this._loggingProvider = loggingProvider;
        }

        public JobList GetByUserId(int id)
        {
            JobList JobList = new JobList();
            try
            {
                JobList = _db.JobList.Find(id);
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to get a User by ID: {0}", id));
            }

            if (JobList == null)
            {
                JobList = new JobList();
            }
            return JobList;
        }

        public List<JobList> GetList()
        {
            List<JobList> jobList = null;

            try
            {
                jobList = (from user in _db.JobList
                            select user).ToList();
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, "Failed to get a user list");
            }

            if (jobList == null)
            {
                jobList = new List<JobList>();
            }

            return jobList;
        }

    }
}
