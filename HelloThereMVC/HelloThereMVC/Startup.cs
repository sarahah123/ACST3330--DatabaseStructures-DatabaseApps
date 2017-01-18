using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloThereMVC.Startup))]
namespace HelloThereMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
