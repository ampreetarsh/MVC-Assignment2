using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAssignment2.Startup))]
namespace MvcAssignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
