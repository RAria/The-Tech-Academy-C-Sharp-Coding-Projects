using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Car_Insurance_Project.Startup))]
namespace Car_Insurance_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
