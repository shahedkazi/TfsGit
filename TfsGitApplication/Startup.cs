using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TfsGitApplication.Startup))]
namespace TfsGitApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
