using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SLD521_FA1_9205.Startup))]
namespace SLD521_FA1_9205
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
