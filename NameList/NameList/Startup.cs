using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NameList.Startup))]
namespace NameList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
