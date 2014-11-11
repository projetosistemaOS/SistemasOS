using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaOSMVC.Startup))]
namespace SistemaOSMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
