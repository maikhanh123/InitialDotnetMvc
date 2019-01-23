using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InitialProject.Startup))]
namespace InitialProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
