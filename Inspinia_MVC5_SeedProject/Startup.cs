using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErypsoBizPlus.Startup))]
namespace ErypsoBizPlus
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
