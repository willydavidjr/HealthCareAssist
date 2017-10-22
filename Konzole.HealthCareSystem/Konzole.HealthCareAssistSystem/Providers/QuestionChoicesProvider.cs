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
    public class QuestionChoicesProvider : BaseProvider, IQuestionChoicesProvider
    {

        public QuestionChoicesProvider(ApplicationDbContext context, ILoggingProvider loggingProvider)
        {
            this._db = context;
            this._loggingProvider = loggingProvider;
        }


        public QuestionChoices GetByUserId(int id)
        {
            QuestionChoices user = new QuestionChoices();
            try
            {
                user = _db.QuestionChoices.Find(id);
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to get a User by ID: {0}", id));
            }

            if (user == null)
            {
                user = new QuestionChoices();
            }
            return user;
        }

        public List<QuestionChoices> GetList()
        {
            List<QuestionChoices> QuestionChoicesList = null;

            try
            {
                QuestionChoicesList = (from questionList in _db.QuestionChoices
                                       select questionList).ToList();
            }

            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, "Failed to get a question list");
            }

            if (QuestionChoicesList == null)
            {
                QuestionChoicesList = new List<QuestionChoices>();
            }

            return QuestionChoicesList;
        }
    }
}
