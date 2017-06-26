using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Schoolmvc.Startup))]
namespace Schoolmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
