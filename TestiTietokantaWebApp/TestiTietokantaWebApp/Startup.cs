using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestiTietokantaWebApp.Startup))]
namespace TestiTietokantaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
