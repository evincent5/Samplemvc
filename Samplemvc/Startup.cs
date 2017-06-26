using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Samplemvc.Startup))]
namespace Samplemvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
