using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebAPIUI.Startup))]

namespace WebAPIUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
