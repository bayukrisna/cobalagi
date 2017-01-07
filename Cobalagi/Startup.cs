using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cobalagi.Startup))]
namespace Cobalagi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
