using System.Web.Mvc;
using Konzole.HealthCareAssistSystem.Providers;
using Konzole.HealthCareAssistSystem.Providers.Interface;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace Konzole.HealthCareAssistSystem.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
         
            container.RegisterType<IQuestionChoicesProvider, QuestionChoicesProvider>();
            container.RegisterType<IQuestionProvider, QuestionProvider>();
            container.RegisterType<ILoggingProvider, LoggingProvider>();
            container.RegisterType<IJobListProvider, JobListProvider>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}