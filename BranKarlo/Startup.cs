using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BranKarlo.Startup))]
namespace BranKarlo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
