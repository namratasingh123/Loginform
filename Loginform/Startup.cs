using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Loginform.Startup))]
namespace Loginform
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
