using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quartzdemo.Startup))]
namespace Quartzdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
