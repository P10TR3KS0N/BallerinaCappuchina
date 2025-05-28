using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BallerinaCappucina01.Startup))]
namespace BallerinaCappucina01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
