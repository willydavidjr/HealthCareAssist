using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzole.HealthCareAssistSystem.Entities
{
    [Table("JobList", Schema = "HR")]
    public class JobList
    {

        public int Id { get; set; }
        public string JobName { get; set; }

        public string JobDescription { get; set; }

        public string JobShortDescription { get; set; }
        public string Status { get; set; }
    }
}
