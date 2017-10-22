using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konzole.HealthCareAssistSystem.Entities;

namespace Konzole.HealthCareAssistSystem.Providers.Interface
{
    public interface IQuestionChoicesProvider
    {
        QuestionChoices GetByUserId(int userid);
        List<QuestionChoices> GetList();
      
    }
}
