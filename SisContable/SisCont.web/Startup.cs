using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SisCont.web.Startup))]
namespace SisCont.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
