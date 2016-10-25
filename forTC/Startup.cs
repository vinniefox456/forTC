using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(forTC.Startup))]
namespace forTC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
