using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(portfolio2.Startup))]
namespace portfolio2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
