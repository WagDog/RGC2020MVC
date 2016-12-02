using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RGC2020MVC.WebUI.Startup))]
namespace RGC2020MVC.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
