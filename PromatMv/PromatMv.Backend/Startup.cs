using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PromatMv.Backend.Startup))]
namespace PromatMv.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
