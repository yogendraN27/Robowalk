using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RoboWalk.Startup))]
namespace RoboWalk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
