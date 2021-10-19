using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SahilCoRetailManager.Startup))]

namespace SahilCoRetailManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
