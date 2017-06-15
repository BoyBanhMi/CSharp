using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KT_14DC110.Startup))]
namespace KT_14DC110
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
