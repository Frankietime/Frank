using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Frank.Startup))]
namespace Frank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
