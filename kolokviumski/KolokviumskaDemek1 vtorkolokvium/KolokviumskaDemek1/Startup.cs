using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KolokviumskaDemek1.Startup))]
namespace KolokviumskaDemek1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
