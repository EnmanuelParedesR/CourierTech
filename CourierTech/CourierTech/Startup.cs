using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourierTech.Startup))]
namespace CourierTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
