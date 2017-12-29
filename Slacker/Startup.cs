using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Slacker.Startup))]
namespace Slacker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
