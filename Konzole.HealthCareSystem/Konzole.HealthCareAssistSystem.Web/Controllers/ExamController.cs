using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Konzole.HealthCareAssistSystem.Entities;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Konzole.HealthCareAssistSystem.Web.Models;

namespace Konzole.HealthCareAssistSystem.Web.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam

        private IQuestionProvider _QuestionProvider = null;
        private IQuestionChoicesProvider _QuestionChoicesProvider = null;

        public ExamController(IQuestionProvider QuestionProvider, IQuestionChoicesProvider QuestionChoicesProvider)
        {
            this._QuestionProvider = QuestionProvider;
            this._QuestionChoicesProvider = QuestionChoicesProvider;
        }


        public ActionResult Index()
        {
            ExamViewModel mod = new ExamViewModel();
            mod.TimeStart = DateTime.Now;
            mod.TimeEnd = DateTime.Now;

            //string strQuestion = string.Empty;
            //strQuestion = _QuestionProvider.GetList().Where(x => x.Id == 1).Select(x => x.Questions).Take(1).SingleOrDefault();

            //List<string> lstQuestionAnswer = new List<string>();
            //lstQuestionAnswer = _QuestionChoicesProvider.GetList().Where(x => x.Sequence == 1).Select(x => x.Choices).ToList();

            List<Question> lstQuestion = new List<Question>();
            lstQuestion = _QuestionProvider.GetList().ToList();

            List<QuestionChoices> lstQuestionAnswer = new List<QuestionChoices>();
            lstQuestionAnswer = _QuestionChoicesProvider.GetList().ToList();



            mod.Question = lstQuestion;
            mod.Choices = lstQuestionAnswer;


            return View(mod);
        }

        

    }
}