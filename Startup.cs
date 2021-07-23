using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Veenca.Startup))]
namespace Veenca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
