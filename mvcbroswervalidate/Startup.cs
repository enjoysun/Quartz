using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mvcbroswervalidate.Startup))]
namespace mvcbroswervalidate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
