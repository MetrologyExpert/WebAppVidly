using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppVidly.Startup))]
namespace WebAppVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
