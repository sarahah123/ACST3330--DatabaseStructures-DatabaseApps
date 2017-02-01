using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(input.Startup))]
namespace input
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
