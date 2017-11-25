using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CsharpMediaQuery2017.Startup))]
namespace CsharpMediaQuery2017
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
