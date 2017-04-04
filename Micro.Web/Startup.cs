using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Micro.Web.Startup))]
namespace Micro.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
