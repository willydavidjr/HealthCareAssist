using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Konzole.HealthCareAssistSystem.Entities;

namespace Konzole.HealthCareAssistSystem.Web.Models
{
    public class ExamViewModel
    {

        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }

        public List<Question> Question { get; set; }
        public List<QuestionChoices> Choices { get; set; }




    }
}