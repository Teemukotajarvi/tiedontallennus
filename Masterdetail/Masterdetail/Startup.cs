using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Masterdetail.Startup))]
namespace Masterdetail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
