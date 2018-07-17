using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PubsProject.Startup))]
namespace PubsProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
