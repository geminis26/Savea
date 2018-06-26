using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Savea.Startup))]
namespace Savea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
