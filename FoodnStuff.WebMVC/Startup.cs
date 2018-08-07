using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodnStuff.WebMVC.Startup))]
namespace FoodnStuff.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
