using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMS1._0.Startup))]
namespace SMS1._0
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
