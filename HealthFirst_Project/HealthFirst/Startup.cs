using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthFirst.Startup))]
namespace HealthFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
