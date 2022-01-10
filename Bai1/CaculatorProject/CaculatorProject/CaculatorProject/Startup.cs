using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaculatorProject.Startup))]
namespace CaculatorProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
