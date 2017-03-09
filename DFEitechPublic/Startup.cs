using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DFEitechPublic.Startup))]
namespace DFEitechPublic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
