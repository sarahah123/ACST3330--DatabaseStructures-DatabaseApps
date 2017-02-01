using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamsAndAverages.Startup))]
namespace ExamsAndAverages
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
