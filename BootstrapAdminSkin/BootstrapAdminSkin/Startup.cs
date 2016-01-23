using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapAdminSkin.Startup))]
namespace BootstrapAdminSkin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
