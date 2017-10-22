using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Konzole.HealthCareAssistSystem.Web.Startup))]
namespace Konzole.HealthCareAssistSystem.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
