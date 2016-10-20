using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angular4DotNetMVC.Startup))]
namespace Angular4DotNetMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
