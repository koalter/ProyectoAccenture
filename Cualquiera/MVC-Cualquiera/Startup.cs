using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Cualquiera.Startup))]
namespace MVC_Cualquiera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
