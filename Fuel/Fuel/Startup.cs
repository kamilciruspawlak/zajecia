using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fuel.Startup))]
namespace Fuel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
