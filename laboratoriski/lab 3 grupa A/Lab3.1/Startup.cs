using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3._1.Startup))]
namespace Lab3._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
