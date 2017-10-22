using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Konzole.HealthCareAssistSystem.Entities
{
    [Table("ExamQuestChoices", Schema = "HR")]
    public class QuestionChoices
    {
        public int id { get; set; }
        public int Sequence { get; set; }
        public string Choices { get; set; }
    }
}
