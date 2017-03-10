using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bundlesdemo.Startup))]
namespace bundlesdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
