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
   public class QuestionProvider : BaseProvider, IQuestionProvider
    {

        public QuestionProvider(ApplicationDbContext context, ILoggingProvider loggingProvider)
        {
            this._db = context;
            this._loggingProvider = loggingProvider;
        }


        public Question GetByUserId(int id)
        {
            Question user = new Question();
            try
            {
                user = _db.Question.Find(id);
            }
            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, string.Format("Failed to get a User by ID: {0}", id));
            }

            if (user == null)
            {
                user = new Question();
            }
            return user;
        }

        public List<Question> GetList()
        {
            List<Question> QuestionList = null;

            try
            {
                QuestionList = (from question in _db.Question
                            select question).ToList();
            }

            catch (Exception ex)
            {
                _loggingProvider.LogError(ex, "Failed to get a question list");
            }

            if (QuestionList == null)
            {
                QuestionList = new List<Question>();
            }

            return QuestionList;
        }
    }
}
