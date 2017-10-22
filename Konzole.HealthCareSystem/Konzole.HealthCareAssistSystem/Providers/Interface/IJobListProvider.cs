using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;

namespace Konzole.HealthCareAssistSystem.Providers.Interface
{
    public interface IJobListProvider
    {

        JobList GetByUserId(int userid);
        List<JobList> GetList();
    }
}
