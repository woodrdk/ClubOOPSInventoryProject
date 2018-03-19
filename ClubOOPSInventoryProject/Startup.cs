using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClubOOPSInventoryProject.Startup))]
namespace ClubOOPSInventoryProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
