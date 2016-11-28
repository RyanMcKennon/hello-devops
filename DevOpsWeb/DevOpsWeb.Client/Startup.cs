using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevOpsWeb.Client.Startup))]
namespace DevOpsWeb.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
