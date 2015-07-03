using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMVCWebApp.Startup))]
namespace MyMVCWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
