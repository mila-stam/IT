using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KolokviumskaDemekCarService.Startup))]
namespace KolokviumskaDemekCarService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
