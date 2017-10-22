using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Konzole.HealthCareAssistSystem.Entities
{
    [Table("ExamQuestion", Schema = "HR")]
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Questions { get; set; }

        public string Answer { get; set; }

    }
}
